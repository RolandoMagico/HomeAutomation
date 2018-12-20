// <copyright file="WANCommonInterfaceConfigX_AVM_DE_GetOnlineMonitorResult.cs" company="ContextQuickie">
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
  /// Result type for X_AVM_DE_GetOnlineMonitor in service WANCommonInterfaceConfig.
  /// </summary>
  public class WANCommonInterfaceConfigX_AVM_DE_GetOnlineMonitorResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewTotalNumberSyncGroups.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewTotalNumberSyncGroups")]
    public uint NewTotalNumberSyncGroups { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSyncGroupName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSyncGroupName")]
    public string NewSyncGroupName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSyncGroupMode.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSyncGroupMode")]
    public string NewSyncGroupMode { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument Newmax_ds.
    /// </summary>
    [System.Xml.Serialization.XmlElement("Newmax_ds")]
    public uint Newmax_ds { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument Newmax_us.
    /// </summary>
    [System.Xml.Serialization.XmlElement("Newmax_us")]
    public uint Newmax_us { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument Newds_current_bps.
    /// </summary>
    [System.Xml.Serialization.XmlElement("Newds_current_bps")]
    public string Newds_current_bps { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument Newmc_current_bps.
    /// </summary>
    [System.Xml.Serialization.XmlElement("Newmc_current_bps")]
    public string Newmc_current_bps { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument Newus_current_bps.
    /// </summary>
    [System.Xml.Serialization.XmlElement("Newus_current_bps")]
    public string Newus_current_bps { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument Newprio_realtime_bps.
    /// </summary>
    [System.Xml.Serialization.XmlElement("Newprio_realtime_bps")]
    public string Newprio_realtime_bps { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument Newprio_high_bps.
    /// </summary>
    [System.Xml.Serialization.XmlElement("Newprio_high_bps")]
    public string Newprio_high_bps { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument Newprio_default_bps.
    /// </summary>
    [System.Xml.Serialization.XmlElement("Newprio_default_bps")]
    public string Newprio_default_bps { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument Newprio_low_bps.
    /// </summary>
    [System.Xml.Serialization.XmlElement("Newprio_low_bps")]
    public string Newprio_low_bps { get; set; }
  }
}
