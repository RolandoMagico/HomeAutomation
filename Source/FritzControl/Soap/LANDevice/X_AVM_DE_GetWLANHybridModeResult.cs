// <copyright file="X_AVM_DE_GetWLANHybridModeResult.cs" company="ContextQuickie">
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
  /// Result type for X_AVM_DE_GetWLANHybridMode.
  /// </summary>
  public class X_AVM_DE_GetWLANHybridModeResult
  {
    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewEnable is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewEnable")]
    public bool NewEnable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewBeaconType.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewBeaconType")]
    public string NewBeaconType { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewKeyPassphrase.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewKeyPassphrase")]
    public string NewKeyPassphrase { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSSID.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSSID")]
    public string NewSSID { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewBSSID.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewBSSID")]
    public string NewBSSID { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTrafficMode.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewTrafficMode")]
    public string NewTrafficMode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewManualSpeed is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewManualSpeed")]
    public bool NewManualSpeed { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxSpeedDS.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxSpeedDS")]
    public uint NewMaxSpeedDS { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxSpeedUS.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxSpeedUS")]
    public uint NewMaxSpeedUS { get; set; }
  }
}
