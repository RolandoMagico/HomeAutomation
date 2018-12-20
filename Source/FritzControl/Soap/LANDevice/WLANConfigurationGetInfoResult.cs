// <copyright file="WLANConfigurationGetInfoResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfo in service WLANConfiguration.
  /// </summary>
  public class WLANConfigurationGetInfoResult
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
    /// Gets or sets the SOAP argument NewMaxBitRate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxBitRate")]
    public string NewMaxBitRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewChannel.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewChannel")]
    public byte NewChannel { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSSID.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSSID")]
    public string NewSSID { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewBeaconType.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewBeaconType")]
    public string NewBeaconType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewMACAddressControlEnabled is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMACAddressControlEnabled")]
    public bool NewMACAddressControlEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewStandard.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewStandard")]
    public string NewStandard { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewBSSID.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewBSSID")]
    public string NewBSSID { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewBasicEncryptionModes.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewBasicEncryptionModes")]
    public string NewBasicEncryptionModes { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewBasicAuthenticationMode.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewBasicAuthenticationMode")]
    public string NewBasicAuthenticationMode { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsSSID.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsSSID")]
    public byte NewMaxCharsSSID { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsSSID.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsSSID")]
    public byte NewMinCharsSSID { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsSSID.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsSSID")]
    public string NewAllowedCharsSSID { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsPSK.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsPSK")]
    public byte NewMinCharsPSK { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsPSK.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsPSK")]
    public byte NewMaxCharsPSK { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsPSK.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsPSK")]
    public string NewAllowedCharsPSK { get; set; }
  }
}
