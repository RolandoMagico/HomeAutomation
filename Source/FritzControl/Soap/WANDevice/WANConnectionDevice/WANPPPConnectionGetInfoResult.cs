// <copyright file="WANPPPConnectionGetInfoResult.cs" company="ContextQuickie">
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
namespace FritzControl.Soap.WANDevice.WANConnectionDevice
{
  /// <summary>
  /// Result type for GetInfo in service WANPPPConnection.
  /// </summary>
  public class WANPPPConnectionGetInfoResult
  {
    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewEnable is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewEnable")]
    public bool NewEnable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewConnectionStatus.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewConnectionStatus")]
    public string NewConnectionStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPossibleConnectionTypes.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPossibleConnectionTypes")]
    public string NewPossibleConnectionTypes { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewConnectionType.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewConnectionType")]
    public string NewConnectionType { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewName")]
    public string NewName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUptime.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUptime")]
    public uint NewUptime { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamMaxBitRate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpstreamMaxBitRate")]
    public uint NewUpstreamMaxBitRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamMaxBitRate.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDownstreamMaxBitRate")]
    public uint NewDownstreamMaxBitRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLastConnectionError.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewLastConnectionError")]
    public string NewLastConnectionError { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewIdleDisconnectTime.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewIdleDisconnectTime")]
    public uint NewIdleDisconnectTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewRSIPAvailable is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewRSIPAvailable")]
    public bool NewRSIPAvailable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUserName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUserName")]
    public string NewUserName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewNATEnabled is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewNATEnabled")]
    public bool NewNATEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewExternalIPAddress.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewExternalIPAddress")]
    public string NewExternalIPAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDNSServers.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDNSServers")]
    public string NewDNSServers { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMACAddress.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMACAddress")]
    public string NewMACAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewConnectionTrigger.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewConnectionTrigger")]
    public string NewConnectionTrigger { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLastAuthErrorInfo.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewLastAuthErrorInfo")]
    public string NewLastAuthErrorInfo { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsUsername")]
    public ushort NewMaxCharsUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsUsername")]
    public ushort NewMinCharsUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsUsername.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsUsername")]
    public string NewAllowedCharsUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsPassword.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMaxCharsPassword")]
    public ushort NewMaxCharsPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsPassword.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMinCharsPassword")]
    public ushort NewMinCharsPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsPassword.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAllowedCharsPassword")]
    public string NewAllowedCharsPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTransportType.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewTransportType")]
    public string NewTransportType { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewRouteProtocolRx.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewRouteProtocolRx")]
    public string NewRouteProtocolRx { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPPPoEServiceName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPPPoEServiceName")]
    public string NewPPPoEServiceName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewRemoteIPAddress.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewRemoteIPAddress")]
    public string NewRemoteIPAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPPPoEACName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPPPoEACName")]
    public string NewPPPoEACName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewDNSEnabled is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDNSEnabled")]
    public bool NewDNSEnabled { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewDNSOverrideAllowed is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDNSOverrideAllowed")]
    public bool NewDNSOverrideAllowed { get; set; }
  }
}
