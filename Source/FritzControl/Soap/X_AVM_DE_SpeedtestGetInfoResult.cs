// <copyright file="X_AVM_DE_SpeedtestGetInfoResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfo in service X_AVM_DE_Speedtest.
  /// </summary>
  public class X_AVM_DE_SpeedtestGetInfoResult
  {
    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewEnableTcp is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewEnableTcp")]
    public bool NewEnableTcp { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewEnableUdp is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewEnableUdp")]
    public bool NewEnableUdp { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewEnableUdpBidirect is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewEnableUdpBidirect")]
    public bool NewEnableUdpBidirect { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewWANEnableTcp is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewWANEnableTcp")]
    public bool NewWANEnableTcp { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewWANEnableUdp is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewWANEnableUdp")]
    public bool NewWANEnableUdp { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPortTcp.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPortTcp")]
    public uint NewPortTcp { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPortUdp.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPortUdp")]
    public uint NewPortUdp { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPortUdpBidirect.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPortUdpBidirect")]
    public uint NewPortUdpBidirect { get; set; }
  }
}
