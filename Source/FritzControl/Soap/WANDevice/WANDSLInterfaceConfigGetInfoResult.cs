// <copyright file="WANDSLInterfaceConfigGetInfoResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfo in service WANDSLInterfaceConfig.
  /// </summary>
  public class WANDSLInterfaceConfigGetInfoResult
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
    /// Gets or sets the SOAP argument NewDataPath.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDataPath")]
    public string NewDataPath { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamCurrRate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpstreamCurrRate")]
    public int NewUpstreamCurrRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamCurrRate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDownstreamCurrRate")]
    public uint NewDownstreamCurrRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamMaxRate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpstreamMaxRate")]
    public uint NewUpstreamMaxRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamMaxRate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDownstreamMaxRate")]
    public uint NewDownstreamMaxRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamNoiseMargin.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpstreamNoiseMargin")]
    public uint NewUpstreamNoiseMargin { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamNoiseMargin.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDownstreamNoiseMargin")]
    public uint NewDownstreamNoiseMargin { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamAttenuation.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpstreamAttenuation")]
    public uint NewUpstreamAttenuation { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamAttenuation.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDownstreamAttenuation")]
    public uint NewDownstreamAttenuation { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewATURVendor.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewATURVendor")]
    public string NewATURVendor { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewATURCountry.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewATURCountry")]
    public string NewATURCountry { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamPower.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpstreamPower")]
    public ushort NewUpstreamPower { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamPower.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDownstreamPower")]
    public ushort NewDownstreamPower { get; set; }
  }
}
