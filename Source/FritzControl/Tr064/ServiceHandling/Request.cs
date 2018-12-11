// <copyright file="Request.cs" company="ContextQuickie">
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
namespace FritzControl.Tr064.ServiceHandling
{
  using System.Xml;
  using System.Xml.Schema;
  using System.Xml.Serialization;

  /// <summary>
  /// Class for creating a SOAP request.
  /// </summary>
  public class Request : IXmlSerializable
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Request"/> class.
    /// This default constructor should only be used by XML serialization.
    /// </summary>
    public Request()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Request"/> class.
    /// </summary>
    /// <param name="service">The service for this request.</param>
    /// <param name="action">The action for this request.</param>
    public Request(Service service, Action action)
    {
      this.Action = action;
      this.Service = service;
    }

    /// <summary>
    /// Gets or sets the service.
    /// </summary>
    [XmlIgnore]
    public Service Service { get; set; }

    /// <summary>
    /// Gets or sets the action.
    /// </summary>
    [XmlIgnore]
    public Action Action { get; set; }

    /// <inheritdoc/>
    public XmlSchema GetSchema() => null;

    /// <inheritdoc/>
    public void ReadXml(XmlReader reader)
    {
    }

    /// <inheritdoc/>
    public void WriteXml(XmlWriter writer)
    {
      //writer.WriteStartElement("u", $"{this.Action.Name}", this.Service.ServiceType);
      writer.WriteStartElement("u", $"GetSecurityPort", "urn:dslforumorg:service:DeviceInfo:1");
      writer.WriteEndElement();
    }

    /// <summary>
    /// Gets or sets the encoding style.
    /// </summary>
    // [XmlAttribute("encodingStyle")]
    // public string EncodingStyle { get; set; } = "http://schemas.xmlsoap.org/soap/encoding/";
  }
}
