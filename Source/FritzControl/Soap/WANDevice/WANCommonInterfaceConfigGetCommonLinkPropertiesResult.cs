// <copyright file="WANCommonInterfaceConfigGetCommonLinkPropertiesResult.cs" company="ContextQuickie">
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
namespace FritzControl.Soap.WANDevice
{
  /// <summary>
  /// Result type for GetCommonLinkProperties in service WANCommonInterfaceConfig.
  /// </summary>
  public class WANCommonInterfaceConfigGetCommonLinkPropertiesResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewWANAccessType.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewWANAccessType")]
    public string NewWANAccessType { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLayer1UpstreamMaxBitRate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewLayer1UpstreamMaxBitRate")]
    public uint NewLayer1UpstreamMaxBitRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLayer1DownstreamMaxBitRate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewLayer1DownstreamMaxBitRate")]
    public uint NewLayer1DownstreamMaxBitRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPhysicalLinkStatus.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPhysicalLinkStatus")]
    public string NewPhysicalLinkStatus { get; set; }
  }
}
