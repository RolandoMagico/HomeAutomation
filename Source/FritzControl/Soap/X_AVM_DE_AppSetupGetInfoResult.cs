// <copyright file="X_AVM_DE_AppSetupGetInfoResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfo in service X_AVM_DE_AppSetup.
  /// </summary>
  public class X_AVM_DE_AppSetupGetInfoResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsAppId.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsAppId")]
    public ushort NewMinCharsAppId { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsAppId.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsAppId")]
    public ushort NewMaxCharsAppId { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsAppId.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsAppId")]
    public string NewAllowedCharsAppId { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsAppDisplayName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsAppDisplayName")]
    public ushort NewMinCharsAppDisplayName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsAppDisplayName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsAppDisplayName")]
    public ushort NewMaxCharsAppDisplayName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsAppUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsAppUsername")]
    public ushort NewMinCharsAppUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsAppUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsAppUsername")]
    public ushort NewMaxCharsAppUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsAppUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsAppUsername")]
    public string NewAllowedCharsAppUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsAppPassword.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsAppPassword")]
    public ushort NewMinCharsAppPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsAppPassword.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsAppPassword")]
    public ushort NewMaxCharsAppPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsAppPassword.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsAppPassword")]
    public string NewAllowedCharsAppPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsIPSecIdentifier.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsIPSecIdentifier")]
    public ushort NewMinCharsIPSecIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsIPSecIdentifier.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsIPSecIdentifier")]
    public ushort NewMaxCharsIPSecIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsIPSecIdentifier.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsIPSecIdentifier")]
    public string NewAllowedCharsIPSecIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsCryptAlgos.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsCryptAlgos")]
    public string NewAllowedCharsCryptAlgos { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsAppAVMAddress.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsAppAVMAddress")]
    public string NewAllowedCharsAppAVMAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsFilter.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsFilter")]
    public ushort NewMinCharsFilter { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsFilter.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsFilter")]
    public ushort NewMaxCharsFilter { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsFilter.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsFilter")]
    public string NewAllowedCharsFilter { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsIPSecPreSharedKey.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsIPSecPreSharedKey")]
    public ushort NewMinCharsIPSecPreSharedKey { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsIPSecPreSharedKey.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsIPSecPreSharedKey")]
    public ushort NewMaxCharsIPSecPreSharedKey { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsIPSecPreSharedKey.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsIPSecPreSharedKey")]
    public string NewAllowedCharsIPSecPreSharedKey { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsIPSecXauthUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsIPSecXauthUsername")]
    public ushort NewMinCharsIPSecXauthUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsIPSecXauthUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsIPSecXauthUsername")]
    public ushort NewMaxCharsIPSecXauthUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsIPSecXauthUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsIPSecXauthUsername")]
    public string NewAllowedCharsIPSecXauthUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsIPSecXauthPassword.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsIPSecXauthPassword")]
    public ushort NewMinCharsIPSecXauthPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsIPSecXauthPassword.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsIPSecXauthPassword")]
    public ushort NewMaxCharsIPSecXauthPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsIPSecXauthPassword.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsIPSecXauthPassword")]
    public string NewAllowedCharsIPSecXauthPassword { get; set; }
  }
}
