// <copyright file="WANIPConnection.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:WANIPConnection:1
  /// </summary>
  public class WANIPConnection
  {
    /// <summary>
    /// Wrapper for the action GetInfo
    /// </summary>
    public void GetInfo()
    {
    }

    /// <summary>
    /// Wrapper for the action GetConnectionTypeInfo
    /// </summary>
    public void GetConnectionTypeInfo()
    {
    }

    /// <summary>
    /// Wrapper for the action SetConnectionType
    /// </summary>
    /// <param name="newConnectionType">The SOAP parameter NewConnectionType.</param>
    public void SetConnectionType(string newConnectionType)
    {
    }

    /// <summary>
    /// Wrapper for the action GetStatusInfo
    /// </summary>
    public void GetStatusInfo()
    {
    }

    /// <summary>
    /// Wrapper for the action GetNATRSIPStatus
    /// </summary>
    public void GetNATRSIPStatus()
    {
    }

    /// <summary>
    /// Wrapper for the action SetConnectionTrigger
    /// </summary>
    /// <param name="newConnectionTrigger">The SOAP parameter NewConnectionTrigger.</param>
    public void SetConnectionTrigger(string newConnectionTrigger)
    {
    }

    /// <summary>
    /// Wrapper for the action ForceTermination
    /// </summary>
    public void ForceTermination()
    {
    }

    /// <summary>
    /// Wrapper for the action RequestConnection
    /// </summary>
    public void RequestConnection()
    {
    }

    /// <summary>
    /// Wrapper for the action GetGenericPortMappingEntry
    /// </summary>
    /// <param name="newPortMappingIndex">The SOAP parameter NewPortMappingIndex.</param>
    public void GetGenericPortMappingEntry(ushort newPortMappingIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action GetSpecificPortMappingEntry
    /// </summary>
    /// <param name="newRemoteHost">The SOAP parameter NewRemoteHost.</param>
    /// <param name="newExternalPort">The SOAP parameter NewExternalPort.</param>
    /// <param name="newProtocol">The SOAP parameter NewProtocol.</param>
    public void GetSpecificPortMappingEntry(string newRemoteHost, ushort newExternalPort, string newProtocol)
    {
    }

    /// <summary>
    /// Wrapper for the action AddPortMapping
    /// </summary>
    /// <param name="newRemoteHost">The SOAP parameter NewRemoteHost.</param>
    /// <param name="newExternalPort">The SOAP parameter NewExternalPort.</param>
    /// <param name="newProtocol">The SOAP parameter NewProtocol.</param>
    /// <param name="newInternalPort">The SOAP parameter NewInternalPort.</param>
    /// <param name="newInternalClient">The SOAP parameter NewInternalClient.</param>
    /// <param name="newEnabled">The SOAP parameter NewEnabled.</param>
    /// <param name="newPortMappingDescription">The SOAP parameter NewPortMappingDescription.</param>
    /// <param name="newLeaseDuration">The SOAP parameter NewLeaseDuration.</param>
    public void AddPortMapping(string newRemoteHost, ushort newExternalPort, string newProtocol, ushort newInternalPort, string newInternalClient, bool newEnabled, string newPortMappingDescription, uint newLeaseDuration)
    {
    }

    /// <summary>
    /// Wrapper for the action DeletePortMapping
    /// </summary>
    /// <param name="newRemoteHost">The SOAP parameter NewRemoteHost.</param>
    /// <param name="newExternalPort">The SOAP parameter NewExternalPort.</param>
    /// <param name="newProtocol">The SOAP parameter NewProtocol.</param>
    public void DeletePortMapping(string newRemoteHost, ushort newExternalPort, string newProtocol)
    {
    }

    /// <summary>
    /// Wrapper for the action GetExternalIPAddress
    /// </summary>
    public void GetExternalIPAddress()
    {
    }

    /// <summary>
    /// Wrapper for the action X_GetDNSServers
    /// </summary>
    public void X_GetDNSServers()
    {
    }

    /// <summary>
    /// Wrapper for the action GetPortMappingNumberOfEntries
    /// </summary>
    public void GetPortMappingNumberOfEntries()
    {
    }

    /// <summary>
    /// Wrapper for the action SetRouteProtocolRx
    /// </summary>
    /// <param name="newRouteProtocolRx">The SOAP parameter NewRouteProtocolRx.</param>
    public void SetRouteProtocolRx(string newRouteProtocolRx)
    {
    }

    /// <summary>
    /// Wrapper for the action SetIdleDisconnectTime
    /// </summary>
    /// <param name="newIdleDisconnectTime">The SOAP parameter NewIdleDisconnectTime.</param>
    public void SetIdleDisconnectTime(uint newIdleDisconnectTime)
    {
    }
  }
}
