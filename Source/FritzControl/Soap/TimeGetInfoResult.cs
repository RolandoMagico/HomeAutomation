// <copyright file="TimeGetInfoResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfo in service Time.
  /// </summary>
  public class TimeGetInfoResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewNTPServer1.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewNTPServer1")]
    public string NewNTPServer1 { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewNTPServer2.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewNTPServer2")]
    public string NewNTPServer2 { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewCurrentLocalTime.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewCurrentLocalTime")]
    public System.DateTime NewCurrentLocalTime { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLocalTimeZone.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewLocalTimeZone")]
    public string NewLocalTimeZone { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLocalTimeZoneName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewLocalTimeZoneName")]
    public string NewLocalTimeZoneName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewDaylightSavingsUsed is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDaylightSavingsUsed")]
    public bool NewDaylightSavingsUsed { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDaylightSavingsStart.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDaylightSavingsStart")]
    public System.DateTime NewDaylightSavingsStart { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDaylightSavingsEnd.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDaylightSavingsEnd")]
    public System.DateTime NewDaylightSavingsEnd { get; set; }
  }
}
