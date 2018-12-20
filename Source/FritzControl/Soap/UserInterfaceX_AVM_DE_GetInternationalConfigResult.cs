// <copyright file="UserInterfaceX_AVM_DE_GetInternationalConfigResult.cs" company="ContextQuickie">
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
  /// Result type for X_AVM_DE_GetInternationalConfig in service UserInterface.
  /// </summary>
  public class UserInterfaceX_AVM_DE_GetInternationalConfigResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_Language.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_Language")]
    public string NewX_AVM_DE_Language { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_Country.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_Country")]
    public string NewX_AVM_DE_Country { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_Annex.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_Annex")]
    public string NewX_AVM_DE_Annex { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_LanguageList.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_LanguageList")]
    public string NewX_AVM_DE_LanguageList { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_CountryList.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_CountryList")]
    public string NewX_AVM_DE_CountryList { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_AnnexList.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewX_AVM-DE_AnnexList")]
    public string NewX_AVM_DE_AnnexList { get; set; }
  }
}
