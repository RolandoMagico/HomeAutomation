// <copyright file="WANDSLInterfaceConfigGetStatisticsTotalResult.cs" company="ContextQuickie">
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
  /// Result type for GetStatisticsTotal in service WANDSLInterfaceConfig.
  /// </summary>
  public class WANDSLInterfaceConfigGetStatisticsTotalResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewReceiveBlocks.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewReceiveBlocks")]
    public uint NewReceiveBlocks { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTransmitBlocks.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewTransmitBlocks")]
    public uint NewTransmitBlocks { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewCellDelin.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewCellDelin")]
    public uint NewCellDelin { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLinkRetrain.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewLinkRetrain")]
    public uint NewLinkRetrain { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewInitErrors.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewInitErrors")]
    public uint NewInitErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewInitTimeouts.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewInitTimeouts")]
    public uint NewInitTimeouts { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLossOfFraming.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewLossOfFraming")]
    public uint NewLossOfFraming { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewErroredSecs.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewErroredSecs")]
    public uint NewErroredSecs { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSeverelyErroredSecs.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSeverelyErroredSecs")]
    public uint NewSeverelyErroredSecs { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewFECErrors.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewFECErrors")]
    public uint NewFECErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewATUCFECErrors.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewATUCFECErrors")]
    public uint NewATUCFECErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHECErrors.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHECErrors")]
    public uint NewHECErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewATUCHECErrors.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewATUCHECErrors")]
    public uint NewATUCHECErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewCRCErrors.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewCRCErrors")]
    public uint NewCRCErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewATUCCRCErrors.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewATUCCRCErrors")]
    public uint NewATUCCRCErrors { get; set; }
  }
}
