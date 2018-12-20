// <copyright file="WANPPPConnection.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:WANPPPConnection:1.
  /// </summary>
  public class WANPPPConnection : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:WANPPPConnection:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (GetInfoResult) of the action.</returns>
    public GetInfoResult GetInfo()
    {
      return this.SendRequest<GetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action GetConnectionTypeInfo.
    /// </summary>
    /// <returns>The result (GetConnectionTypeInfoResult) of the action.</returns>
    public GetConnectionTypeInfoResult GetConnectionTypeInfo()
    {
      return this.SendRequest<GetConnectionTypeInfoResult>("GetConnectionTypeInfo");
    }

    /// <summary>
    /// Wrapper for the action SetConnectionType.
    /// </summary>
    /// <param name="newConnectionType">The SOAP parameter NewConnectionType.</param>
    public void SetConnectionType(string newConnectionType)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewConnectionType", newConnectionType);
      this.SendRequest("SetConnectionType", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetStatusInfo.
    /// </summary>
    /// <returns>The result (GetStatusInfoResult) of the action.</returns>
    public GetStatusInfoResult GetStatusInfo()
    {
      return this.SendRequest<GetStatusInfoResult>("GetStatusInfo");
    }

    /// <summary>
    /// Wrapper for the action GetUserName.
    /// </summary>
    /// <returns>The result (NewUserName) of the action.</returns>
    public string GetUserName()
    {
      return this.SendRequest<string>("GetUserName");
    }

    /// <summary>
    /// Wrapper for the action SetUserName.
    /// </summary>
    /// <param name="newUserName">The SOAP parameter NewUserName.</param>
    public void SetUserName(string newUserName)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewUserName", newUserName);
      this.SendRequest("SetUserName", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetPassword.
    /// </summary>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    public void SetPassword(string newPassword)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPassword", newPassword);
      this.SendRequest("SetPassword", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetNATRSIPStatus.
    /// </summary>
    /// <returns>The result (GetNATRSIPStatusResult) of the action.</returns>
    public GetNATRSIPStatusResult GetNATRSIPStatus()
    {
      return this.SendRequest<GetNATRSIPStatusResult>("GetNATRSIPStatus");
    }

    /// <summary>
    /// Wrapper for the action SetConnectionTrigger.
    /// </summary>
    /// <param name="newConnectionTrigger">The SOAP parameter NewConnectionTrigger.</param>
    public void SetConnectionTrigger(string newConnectionTrigger)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewConnectionTrigger", newConnectionTrigger);
      this.SendRequest("SetConnectionTrigger", arguments);
    }

    /// <summary>
    /// Wrapper for the action ForceTermination.
    /// </summary>
    public void ForceTermination()
    {
      this.SendRequest("ForceTermination");
    }

    /// <summary>
    /// Wrapper for the action RequestConnection.
    /// </summary>
    public void RequestConnection()
    {
      this.SendRequest("RequestConnection");
    }

    /// <summary>
    /// Wrapper for the action GetGenericPortMappingEntry.
    /// </summary>
    /// <param name="newPortMappingIndex">The SOAP parameter NewPortMappingIndex.</param>
    /// <returns>The result (GetGenericPortMappingEntryResult) of the action.</returns>
    public GetGenericPortMappingEntryResult GetGenericPortMappingEntry(ushort newPortMappingIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPortMappingIndex", newPortMappingIndex);
      return this.SendRequest<GetGenericPortMappingEntryResult>("GetGenericPortMappingEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetSpecificPortMappingEntry.
    /// </summary>
    /// <param name="newRemoteHost">The SOAP parameter NewRemoteHost.</param>
    /// <param name="newExternalPort">The SOAP parameter NewExternalPort.</param>
    /// <param name="newProtocol">The SOAP parameter NewProtocol.</param>
    /// <returns>The result (GetSpecificPortMappingEntryResult) of the action.</returns>
    public GetSpecificPortMappingEntryResult GetSpecificPortMappingEntry(string newRemoteHost, ushort newExternalPort, string newProtocol)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewRemoteHost", newRemoteHost);
      arguments.Add("NewExternalPort", newExternalPort);
      arguments.Add("NewProtocol", newProtocol);
      return this.SendRequest<GetSpecificPortMappingEntryResult>("GetSpecificPortMappingEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action AddPortMapping.
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
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewRemoteHost", newRemoteHost);
      arguments.Add("NewExternalPort", newExternalPort);
      arguments.Add("NewProtocol", newProtocol);
      arguments.Add("NewInternalPort", newInternalPort);
      arguments.Add("NewInternalClient", newInternalClient);
      arguments.Add("NewEnabled", newEnabled);
      arguments.Add("NewPortMappingDescription", newPortMappingDescription);
      arguments.Add("NewLeaseDuration", newLeaseDuration);
      this.SendRequest("AddPortMapping", arguments);
    }

    /// <summary>
    /// Wrapper for the action DeletePortMapping.
    /// </summary>
    /// <param name="newRemoteHost">The SOAP parameter NewRemoteHost.</param>
    /// <param name="newExternalPort">The SOAP parameter NewExternalPort.</param>
    /// <param name="newProtocol">The SOAP parameter NewProtocol.</param>
    public void DeletePortMapping(string newRemoteHost, ushort newExternalPort, string newProtocol)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewRemoteHost", newRemoteHost);
      arguments.Add("NewExternalPort", newExternalPort);
      arguments.Add("NewProtocol", newProtocol);
      this.SendRequest("DeletePortMapping", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetExternalIPAddress.
    /// </summary>
    /// <returns>The result (NewExternalIPAddress) of the action.</returns>
    public string GetExternalIPAddress()
    {
      return this.SendRequest<string>("GetExternalIPAddress");
    }

    /// <summary>
    /// Wrapper for the action X_GetDNSServers.
    /// </summary>
    /// <returns>The result (NewDNSServers) of the action.</returns>
    public string X_GetDNSServers()
    {
      return this.SendRequest<string>("X_GetDNSServers");
    }

    /// <summary>
    /// Wrapper for the action GetLinkLayerMaxBitRates.
    /// </summary>
    /// <returns>The result (GetLinkLayerMaxBitRatesResult) of the action.</returns>
    public GetLinkLayerMaxBitRatesResult GetLinkLayerMaxBitRates()
    {
      return this.SendRequest<GetLinkLayerMaxBitRatesResult>("GetLinkLayerMaxBitRates");
    }

    /// <summary>
    /// Wrapper for the action GetPortMappingNumberOfEntries.
    /// </summary>
    /// <returns>The result (NewPortMappingNumberOfEntries) of the action.</returns>
    public ushort GetPortMappingNumberOfEntries()
    {
      return this.SendRequest<ushort>("GetPortMappingNumberOfEntries");
    }

    /// <summary>
    /// Wrapper for the action SetRouteProtocolRx.
    /// </summary>
    /// <param name="newRouteProtocolRx">The SOAP parameter NewRouteProtocolRx.</param>
    public void SetRouteProtocolRx(string newRouteProtocolRx)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewRouteProtocolRx", newRouteProtocolRx);
      this.SendRequest("SetRouteProtocolRx", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetIdleDisconnectTime.
    /// </summary>
    /// <param name="newIdleDisconnectTime">The SOAP parameter NewIdleDisconnectTime.</param>
    public void SetIdleDisconnectTime(uint newIdleDisconnectTime)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIdleDisconnectTime", newIdleDisconnectTime);
      this.SendRequest("SetIdleDisconnectTime", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetAutoDisconnectTimeSpan.
    /// </summary>
    /// <returns>The result (X_AVM_DE_GetAutoDisconnectTimeSpanResult) of the action.</returns>
    public X_AVM_DE_GetAutoDisconnectTimeSpanResult X_AVM_DE_GetAutoDisconnectTimeSpan()
    {
      return this.SendRequest<X_AVM_DE_GetAutoDisconnectTimeSpanResult>("X_AVM-DE_GetAutoDisconnectTimeSpan");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetAutoDisconnectTimeSpan.
    /// </summary>
    /// <param name="newX_AVM_DE_DisconnectPreventionEnable">The SOAP parameter NewX_AVM-DE_DisconnectPreventionEnable.</param>
    /// <param name="newX_AVM_DE_DisconnectPreventionHour">The SOAP parameter NewX_AVM-DE_DisconnectPreventionHour.</param>
    public void X_AVM_DE_SetAutoDisconnectTimeSpan(bool newX_AVM_DE_DisconnectPreventionEnable, ushort newX_AVM_DE_DisconnectPreventionHour)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewX_AVM-DE_DisconnectPreventionEnable", newX_AVM_DE_DisconnectPreventionEnable);
      arguments.Add("NewX_AVM-DE_DisconnectPreventionHour", newX_AVM_DE_DisconnectPreventionHour);
      this.SendRequest("X_AVM-DE_SetAutoDisconnectTimeSpan", arguments);
    }
  }
}
