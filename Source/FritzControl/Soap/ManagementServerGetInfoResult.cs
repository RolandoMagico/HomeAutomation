// <copyright file="ManagementServerGetInfoResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfo in service ManagementServer.
  /// </summary>
  public class ManagementServerGetInfoResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewURL.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewURL")]
    public string NewURL { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUsername")]
    public string NewUsername { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewPeriodicInformEnable is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPeriodicInformEnable")]
    public bool NewPeriodicInformEnable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPeriodicInformInterval.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPeriodicInformInterval")]
    public uint NewPeriodicInformInterval { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPeriodicInformTime.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPeriodicInformTime")]
    public System.DateTime NewPeriodicInformTime { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewParameterKey.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewParameterKey")]
    public string NewParameterKey { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewParameterHash.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewParameterHash")]
    public string NewParameterHash { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewConnectionRequestURL.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewConnectionRequestURL")]
    public string NewConnectionRequestURL { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewConnectionRequestUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewConnectionRequestUsername")]
    public string NewConnectionRequestUsername { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewUpgradesManaged is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpgradesManaged")]
    public bool NewUpgradesManaged { get; set; }
  }
}
