// <copyright file="Service.cs" company="ContextQuickie">
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
  using System.Xml.Serialization;

  /// <summary>
  /// This class respresents a service node in a <see cref="Device"/> element.
  /// </summary>
  public class Service
  {
    /// <summary>
    /// Gets or sets the service type.
    /// </summary>
    [XmlElement("serviceType")]
    public string ServiceType { get; set; }

    /// <summary>
    /// Gets or sets the service ID.
    /// </summary>
    [XmlElement("serviceId")]
    public string ServiceId { get; set; }

    /// <summary>
    /// Gets or sets the control URL.
    /// </summary>
    [XmlElement("controlURL")]
    public string ControlUrl { get; set; }

    /// <summary>
    /// Gets or sets the event sub URL.
    /// </summary>
    [XmlElement("eventSubURL")]
    public string EventSubUrl { get; set; }

    /// <summary>
    /// Gets or sets the Service Control Protocol Description (SCPD) URL.
    /// </summary>
    [XmlElement("SCPDURL")]
    public string ScpdUrl { get; set; }

    /// <summary>
    /// Gets or sets the Service Control Protocol Description (SCPD).
    /// </summary>
    [XmlIgnore]
    public ServiceControlProtocolDescription Scpd { get; set; }

    /// <inheritdoc/>
    public override string ToString() => this.ServiceId;
  }
}
