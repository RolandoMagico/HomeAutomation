// <copyright file="Device.cs" company="ContextQuickie">
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
namespace FritzControl.Tr064
{
  using System.Collections.Generic;
  using System.Linq;
  using System.Xml.Serialization;

  /// <summary>
  /// This class respresents the Device node in a <see cref="Description"/> element.
  /// </summary>
  public class Device
  {
    /// <summary>
    /// Gets or sets the device type.
    /// </summary>
    [XmlElement("deviceType")]
    public string DeviceType { get; set; }

    /// <summary>
    /// Gets or sets the friendly name.
    /// </summary>
    [XmlElement("friendlyName")]
    public string FriendlyName { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer.
    /// </summary>
    [XmlElement("manufacturer")]
    public string Manufacturer { get; set; }

    /// <summary>
    /// Gets or sets the manufacturer URL.
    /// </summary>
    [XmlElement("manufacturerURL")]
    public string ManufacturerUrl { get; set; }

    /// <summary>
    /// Gets or sets the model description.
    /// </summary>
    [XmlElement("modelDescription")]
    public string ModelDescription { get; set; }

    /// <summary>
    /// Gets or sets the model name.
    /// </summary>
    [XmlElement("modelName")]
    public string ModelName { get; set; }

    /// <summary>
    /// Gets or sets the model number.
    /// </summary>
    [XmlElement("modelNumber")]
    public string ModelNumber { get; set; }

    /// <summary>
    /// Gets or sets the model URL.
    /// </summary>
    [XmlElement("modelURL")]
    public string ModelUrl { get; set; }

    /// <summary>
    /// Gets or sets the presentation URL.
    /// </summary>
    [XmlElement("presentationURL")]
    public string PresentationUrl { get; set; }

    /// <summary>
    /// Gets or sets the unique device name.
    /// </summary>
    [XmlElement("UDN")]
    public string UniqueDeviceName { get; set; }

    /// <summary>
    /// Gets or sets the UDP based Publication Channel (UPC).
    /// </summary>
    [XmlElement("UPC")]
    public string UdpBasedPublicationChannel { get; set; }

    /// <summary>
    /// Gets or sets the icons.
    /// </summary>
    [XmlArrayItem("icon")]
    [XmlArray("iconList")]
    public List<Icon> Icons { get; set; } = new List<Icon>();

    /// <summary>
    /// Gets or sets the services.
    /// </summary>
    [XmlArrayItem("service")]
    [XmlArray("serviceList")]
    public List<SoapService> Services { get; set; } = new List<SoapService>();

    /// <summary>
    /// Gets or sets the services.
    /// </summary>
    [XmlArrayItem("device")]
    [XmlArray("deviceList")]
    public List<Device> Devices { get; set; } = new List<Device>();

    /// <summary>
    /// Gets the service with the specific service ID.
    /// </summary>
    /// <param name="servicType">The service type.</param>
    /// <returns>The service with the specific service ID or <c>null</c> if no service with the service ID is present.</returns>
    public SoapService GetService(string servicType) => this.Services.FirstOrDefault(s => s.ServiceType == servicType);

    /// <summary>
    /// Gets the SOAP operation with the specific service ID and action name.
    /// </summary>
    /// <param name="servicType">The service type.</param>
    /// <param name="actionName">The name of the <see cref="SoapAction"/>.</param>
    /// <returns>The operation with the specific service ID and action name or <c>null</c> if no operation has been found.</returns>
    public SoapOperation GetSoapOperation(string servicType, string actionName)
    {
      List<Device> allDevices = new List<Device>();
      allDevices.Add(this);
      allDevices.AddRange(this.Devices);
      foreach (Device device in allDevices)
      {
        if (device.GetService(servicType) is SoapService service && service.GetAction(actionName) is SoapAction action)
        {
          return new SoapOperation(service, action);
        }
      }

      return null;
    }
  }
}
