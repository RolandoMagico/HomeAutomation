// <copyright file="UserInterfaceGetInfoResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfo in service UserInterface.
  /// </summary>
  public class UserInterfaceGetInfoResult
  {
    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewUpgradeAvailable is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpgradeAvailable")]
    public bool NewUpgradeAvailable { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewPasswordRequired is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPasswordRequired")]
    public bool NewPasswordRequired { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewPasswordUserSelectable is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPasswordUserSelectable")]
    public bool NewPasswordUserSelectable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewWarrantyDate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewWarrantyDate")]
    public System.DateTime NewWarrantyDate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_Version.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_Version")]
    public string NewX_AVM_DE_Version { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_DownloadURL.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_DownloadURL")]
    public string NewX_AVM_DE_DownloadURL { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_InfoURL.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_InfoURL")]
    public string NewX_AVM_DE_InfoURL { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_UpdateState.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_UpdateState")]
    public string NewX_AVM_DE_UpdateState { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_LaborVersion.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_LaborVersion")]
    public string NewX_AVM_DE_LaborVersion { get; set; }
  }
}
