// <copyright file="X_VoIPGetInfoExResult.cs" company="ContextQuickie">
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
namespace FritzControl.Soap
{
  /// <summary>
  /// Result type for GetInfoEx in service X_VoIP.
  /// </summary>
  public class X_VoIPGetInfoExResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPNumberMinChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPNumberMinChars")]
    public ushort NewVoIPNumberMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPNumberMaxChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPNumberMaxChars")]
    public ushort NewVoIPNumberMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPNumberAllowedChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPNumberAllowedChars")]
    public string NewVoIPNumberAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPUsernameMinChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPUsernameMinChars")]
    public ushort NewVoIPUsernameMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPUsernameMaxChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPUsernameMaxChars")]
    public ushort NewVoIPUsernameMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPUsernameAllowedChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPUsernameAllowedChars")]
    public string NewVoIPUsernameAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPPasswordMinChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPPasswordMinChars")]
    public ushort NewVoIPPasswordMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPPasswordMaxChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPPasswordMaxChars")]
    public ushort NewVoIPPasswordMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPPasswordAllowedChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPPasswordAllowedChars")]
    public string NewVoIPPasswordAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPRegistrarMinChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPRegistrarMinChars")]
    public ushort NewVoIPRegistrarMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPRegistrarMaxChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPRegistrarMaxChars")]
    public ushort NewVoIPRegistrarMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPRegistrarAllowedChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPRegistrarAllowedChars")]
    public string NewVoIPRegistrarAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPSTUNServerMinChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPSTUNServerMinChars")]
    public ushort NewVoIPSTUNServerMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPSTUNServerMaxChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPSTUNServerMaxChars")]
    public ushort NewVoIPSTUNServerMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPSTUNServerAllowedChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewVoIPSTUNServerAllowedChars")]
    public string NewVoIPSTUNServerAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientUsernameMinChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_ClientUsernameMinChars")]
    public ushort NewX_AVM_DE_ClientUsernameMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientUsernameMaxChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_ClientUsernameMaxChars")]
    public ushort NewX_AVM_DE_ClientUsernameMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientUsernameAllowedChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_ClientUsernameAllowedChars")]
    public string NewX_AVM_DE_ClientUsernameAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientPasswordMinChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_ClientPasswordMinChars")]
    public ushort NewX_AVM_DE_ClientPasswordMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientPasswordMaxChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_ClientPasswordMaxChars")]
    public ushort NewX_AVM_DE_ClientPasswordMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientPasswordAllowedChars.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_ClientPasswordAllowedChars")]
    public string NewX_AVM_DE_ClientPasswordAllowedChars { get; set; }
  }
}
