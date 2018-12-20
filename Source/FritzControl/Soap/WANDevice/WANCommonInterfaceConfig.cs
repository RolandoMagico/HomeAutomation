// <copyright file="WANCommonInterfaceConfig.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:WANCommonInterfaceConfig:1.
  /// </summary>
  public class WANCommonInterfaceConfig : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:WANCommonInterfaceConfig:1";

    /// <summary>
    /// Wrapper for the action GetCommonLinkProperties.
    /// </summary>
    /// <returns>The result (GetCommonLinkPropertiesResult) of the action.</returns>
    public GetCommonLinkPropertiesResult GetCommonLinkProperties()
    {
      return this.SendRequest<GetCommonLinkPropertiesResult>("GetCommonLinkProperties");
    }

    /// <summary>
    /// Wrapper for the action GetTotalBytesSent.
    /// </summary>
    /// <returns>The result (NewTotalBytesSent) of the action.</returns>
    public uint GetTotalBytesSent()
    {
      return this.SendRequest<uint>("GetTotalBytesSent");
    }

    /// <summary>
    /// Wrapper for the action GetTotalBytesReceived.
    /// </summary>
    /// <returns>The result (NewTotalBytesReceived) of the action.</returns>
    public uint GetTotalBytesReceived()
    {
      return this.SendRequest<uint>("GetTotalBytesReceived");
    }

    /// <summary>
    /// Wrapper for the action GetTotalPacketsSent.
    /// </summary>
    /// <returns>The result (NewTotalPacketsSent) of the action.</returns>
    public uint GetTotalPacketsSent()
    {
      return this.SendRequest<uint>("GetTotalPacketsSent");
    }

    /// <summary>
    /// Wrapper for the action GetTotalPacketsReceived.
    /// </summary>
    /// <returns>The result (NewTotalPacketsReceived) of the action.</returns>
    public uint GetTotalPacketsReceived()
    {
      return this.SendRequest<uint>("GetTotalPacketsReceived");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetWANAccessType.
    /// </summary>
    /// <param name="newAccessType">The SOAP parameter NewAccessType.</param>
    public void X_AVM_DE_SetWANAccessType(string newAccessType)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAccessType", newAccessType);
      this.SendRequest("X_AVM-DE_SetWANAccessType", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetOnlineMonitor.
    /// </summary>
    /// <param name="newSyncGroupIndex">The SOAP parameter NewSyncGroupIndex.</param>
    /// <returns>The result (X_AVM_DE_GetOnlineMonitorResult) of the action.</returns>
    public X_AVM_DE_GetOnlineMonitorResult X_AVM_DE_GetOnlineMonitor(uint newSyncGroupIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewSyncGroupIndex", newSyncGroupIndex);
      return this.SendRequest<X_AVM_DE_GetOnlineMonitorResult>("X_AVM-DE_GetOnlineMonitor", arguments);
    }
  }
}
