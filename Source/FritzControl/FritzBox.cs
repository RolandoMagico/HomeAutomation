// <copyright file="FritzBox.cs" company="ContextQuickie">
// MIT License
//
// Copyright (c) 2018
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </copyright>
namespace FritzControl
{
  using System;
  using System.IO;
  using System.Linq;
  using System.Net;
  using System.Net.Http;
  using System.Security.Cryptography;
  using System.Text;
  using System.Threading.Tasks;
  using System.Xml.Linq;
  using System.Xml.Serialization;
  using FritzControl.Tr064.ServiceHandling;
  using HomeAutomationLib;
  using Tr064;

  /// <summary>
  /// Class for accessing an AVM Fritz Box.
  /// </summary>
  public class FritzBox : BaseLogger
  {
    /// <summary>
    /// Gets or sets the host name of the fritz box.
    /// </summary>
    public string Hostname { get; set; } = "fritz.box";

    /// <summary>
    /// Gets or sets the user name for the access.
    /// </summary>
    public string Username { get; set; } = "Homebridge";

    /// <summary>
    /// Gets or sets the password for the access.
    /// </summary>
    public string Password { get; set; } = "Homebridge1951";

    /// <summary>
    /// Gets or sets the description retrived from the device.
    /// </summary>
    public Description Description { get; set; }

    /// <summary>
    /// Gets or sets the HTTP client which is used for the communication with the fritz box.
    /// </summary>
    private HttpClient HttpClient { get; set; }

    /// <summary>
    /// Connects to the Fritz Box.
    /// </summary>
    public void Connect()
    {
      this.HttpClient = new HttpClient { BaseAddress = new Uri($"http://{this.Hostname}:49000") };
      Log.Debug($"Loading TR-064 description from {this.Hostname}");
      if (this.LoadAndDeserializeXmlData<Description>("/tr64desc.xml", "urn:dslforum-org:device-1-0") is Description description)
      {
        this.Description = description;
        this.LoadDeviceServices(this.Description.Device);
        this.Authenticate();
      }
    }

    /// <summary>
    /// Sends the SOAP request to the fritz box.
    /// </summary>
    /// <param name="request">The request data which should be sent.</param>
    /// <returns>The received response or null if no valid response was received.</returns>
    public Response SendSoapRequest(Request request)
    {
      Response result = null;
      using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, request.Body.Service.ControlUrl))
      {
        if (request.Header.InitialChanllenge == false)
        {
          request.Header.AuthToken = this.CalcuateAuthToken();
        }

        if (request.Body != null)
        {
          httpRequestMessage.Headers.Add("SOAPACTION", $"{request.Body.Service.ServiceType}#{request.Body.Action.Name}");
        }

        XDocument xmlDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
        request.WriteXml(xmlDocument);
        httpRequestMessage.Content = new StringContent(xmlDocument.ToString(), Encoding.UTF8, "text/xml");

        using (HttpResponseMessage response = this.HttpClient.SendAsync(httpRequestMessage).Result)
        {
          if (response.StatusCode == HttpStatusCode.OK)
          {
            result = new Response { Request = request };
            xmlDocument = XDocument.Load(response.Content.ReadAsStreamAsync().Result);
            result.ReadXml(xmlDocument);
          }
          else
          {
            Log.Error($"Status code of response: {response.StatusCode}");
            Log.Error("Response content:");
            Log.Error(new StreamReader(response.Content.ReadAsStreamAsync().Result).ReadToEnd());
          }
        }
      }

      return result;
    }

    /// <summary>
    /// Performs authentification with the current <see cref="Username"/> and <see cref="Password"/>.
    /// </summary>
    private void Authenticate()
    {
      if (this.Description.Device.GetSoapOperation("urn:dslforum-org:service:DeviceInfo:1", "GetInfo") is SoapOperation operation)
      {
        Header initChallenge = new Header { UserId = this.Username, InitialChanllenge = true };
        Request request = new Request { Header = initChallenge, Body = new Body(operation) };
        if (this.SendSoapRequest(request) is Response response)
        {
          Header clientAuthentification = new Header { UserId = this.Username, InitialChanllenge = false, AuthToken = this.CalcuateAuthToken() };
          request = new Request { Header = clientAuthentification, Body = new Body(operation) };
          if (this.SendSoapRequest(request) is Response response2)
          {
          }
        }
      }
    }

    /// <summary>
    /// Calculates the token for the authentification.
    /// </summary>
    /// <returns>The calculated token.</returns>
    private string CalcuateAuthToken()
    {
      MD5 md5 = MD5.Create();
      byte[] hash1 = md5.ComputeHash(Encoding.ASCII.GetBytes($"{this.Username}:{Header.LastRealm}:{this.Password}"));
      string hash1String = string.Concat(hash1.Select(value => value.ToString("x2")));

      byte[] hash2 = md5.ComputeHash(Encoding.ASCII.GetBytes($"{hash1String}:{Header.LastNonce}"));
      string hash2String = string.Concat(hash2.Select(value => value.ToString("x2")));
      return hash2String;
    }

    /// <summary>
    /// Loads the services for the specific device.
    /// </summary>
    /// <param name="device">The device for which the services are loaded.</param>
    private void LoadDeviceServices(Device device)
    {
      Parallel.ForEach(device.Services, service =>
      {
        Log.Debug($"Loading service description from {service.ScpdUrl}");
        service.Scpd = this.LoadAndDeserializeXmlData<ServiceControlProtocolDescription>(service.ScpdUrl, "urn:dslforum-org:service-1-0");
      });

      device.Devices.ForEach(this.LoadDeviceServices);
    }

    /// <summary>
    /// Loads data from the specific URI and deserializes the received data into an object.
    /// </summary>
    /// <typeparam name="T">The type of the deserialized object.</typeparam>
    /// <param name="requestUri">The URI which is used to retrieve the data.</param>
    /// <param name="defaultNamespace">The default namespace which is used for deserialization.</param>
    /// <returns>The created instance of type <typeparamref name="T"/> or null if no valid response was received.</returns>
    private T LoadAndDeserializeXmlData<T>(string requestUri, string defaultNamespace)
      where T : class
    {
      T result = null;
      using (HttpResponseMessage response = this.HttpClient.GetAsync(requestUri).Result)
      {
        if (response.StatusCode == HttpStatusCode.OK)
        {
          XmlSerializer serializer = new XmlSerializer(typeof(T), defaultNamespace);
          serializer.UnknownNode += (object sender, XmlNodeEventArgs e) => Log.Warn($@"Unknown XML {e.NodeType} ""{e.Name}"" in line {e.LineNumber}, position {e.LinePosition}");
          result = serializer.Deserialize(response.Content.ReadAsStreamAsync().Result) as T;
        }
      }

      return result;
    }
  }
}
