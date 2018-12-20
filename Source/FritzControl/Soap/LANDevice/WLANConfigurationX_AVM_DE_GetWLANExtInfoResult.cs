// <copyright file="WLANConfigurationX_AVM_DE_GetWLANExtInfoResult.cs" company="ContextQuickie">
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
  /// Result type for X_AVM_DE_GetWLANExtInfo in service WLANConfiguration.
  /// </summary>
  public class WLANConfigurationX_AVM_DE_GetWLANExtInfoResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_APEnabled.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_APEnabled")]
    public string NewX_AVM_DE_APEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_APType.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_APType")]
    public string NewX_AVM_DE_APType { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_TimeoutActive.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_TimeoutActive")]
    public string NewX_AVM_DE_TimeoutActive { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_Timeout.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_Timeout")]
    public string NewX_AVM_DE_Timeout { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_TimeRemain.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_TimeRemain")]
    public string NewX_AVM_DE_TimeRemain { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_NoForcedOff.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_NoForcedOff")]
    public string NewX_AVM_DE_NoForcedOff { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_UserIsolation.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_UserIsolation")]
    public string NewX_AVM_DE_UserIsolation { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_EncryptionMode.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_EncryptionMode")]
    public string NewX_AVM_DE_EncryptionMode { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_LastChangedStamp.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_LastChangedStamp")]
    public uint NewX_AVM_DE_LastChangedStamp { get; set; }
  }
}
