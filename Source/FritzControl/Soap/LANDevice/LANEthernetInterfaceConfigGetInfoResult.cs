// <copyright file="LANEthernetInterfaceConfigGetInfoResult.cs" company="ContextQuickie">
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
namespace FritzControl.Soap.LANDevice
{
  /// <summary>
  /// Result type for GetInfo in service LANEthernetInterfaceConfig.
  /// </summary>
  public class LANEthernetInterfaceConfigGetInfoResult
  {
    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewEnable is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewEnable")]
    public bool NewEnable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewStatus.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewStatus")]
    public string NewStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMACAddress.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMACAddress")]
    public string NewMACAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxBitRate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxBitRate")]
    public string NewMaxBitRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDuplexMode.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDuplexMode")]
    public string NewDuplexMode { get; set; }
  }
}
