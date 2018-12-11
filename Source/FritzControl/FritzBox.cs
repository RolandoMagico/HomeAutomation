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
  using System.Text;
  using System.Threading.Tasks;
  using System.Xml;
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
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets the password for the access.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets the description retrived from the device.
    /// </summary>
    public Description Description { get; set; }

    /// <summary>
    /// Connects to the Fritz Box.
    /// </summary>
    public void Connect()
    {
      Log.Debug($"Loading TR-064 description from {this.Hostname}");
      if (this.LoadAndDeserializeXmlData<Description>("/tr64desc.xml", "urn:dslforum-org:device-1-0") is Description description)
      {
        this.Description = description;
        this.LoadDeviceServices(this.Description.Device);
      }
    }

    /// <summary>
    /// Loads information about home automation from the device.
    /// </summary>
    public void LoadHomeAutomationInfo()
    {
      if (this.Description.Device.Services.FirstOrDefault(s => s.ServiceId.EndsWith("DE_Homeauto1")) is Service service)
      {
        Request request = new Request(service, service.Scpd.Actions.First());
        if (this.LoadAndDeserializeXmlData<Response>(service.ControlUrl, "http://schemas.xmlsoap.org/soap/envelope/", new Envelope { Request = request }) is Response response)
        {
        }
      }
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
    /// <param name="request">The request data which should be sent. can be <c>null</c>.</param>
    /// <returns>The created instance of type <typeparamref name="T"/> or null if no valid response was received.</returns>
    private T LoadAndDeserializeXmlData<T>(string requestUri, string defaultNamespace, Envelope request = null)
      where T : class
    {
      T result = null;
      HttpClient httpClient = new HttpClient { BaseAddress = new Uri($"http://{this.Hostname}:49000") };
      HttpResponseMessage response;
      if (request != null)
      {
        HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
        //httpRequestMessage.Version = HttpVersion.Version11;
        httpRequestMessage.Headers.Add("SOAPACTION", $"{request.Request.Service.ServiceType}#{request.Request.Action.Name}");
        //httpRequestMessage.Headers.Add("soapaction", $"\"urn:dslforum-org:service:DeviceInfo:1#GetSecurityPort\"");
        //httpRequestMessage.Headers.Add("soapaction", $"urn:schemas-upnp-org:service:WANIPConnection:1#GetStatusInfo");
        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
        ns.Add("s", defaultNamespace);
        XmlSerializer serializer = new XmlSerializer(request.GetType());
        using (StringWriter stringWriter = new StringWriter())
        {
          serializer.Serialize(stringWriter, request, ns);
          httpRequestMessage.Content = new StringContent(stringWriter.ToString(), Encoding.UTF8, "text/xml");
        }

        response = httpClient.SendAsync(httpRequestMessage).Result;
      }
      else
      {
        response = httpClient.GetAsync(requestUri).Result;
      }

      if (response.StatusCode == HttpStatusCode.OK)
      {
        XmlSerializer serializer = new XmlSerializer(typeof(T), defaultNamespace);
        serializer.UnknownAttribute += (object sender, XmlAttributeEventArgs e) => Log.Warn($@"Unknown XML attribute ""{e.Attr.Name}"" in line {e.LineNumber}, position {e.LinePosition}");
        serializer.UnknownElement += (object sender, XmlElementEventArgs e) => Log.Warn($@"Unknown XML element ""{e.Element.Name}"" in line {e.LineNumber}, position {e.LinePosition}");
        serializer.UnknownNode += (object sender, XmlNodeEventArgs e) => Log.Warn($@"Unknown XML node ""{e.Name}"" in line {e.LineNumber}, position {e.LinePosition}");
        result = serializer.Deserialize(response.Content.ReadAsStreamAsync().Result) as T;
      }

      return result;
    }
  }
}
