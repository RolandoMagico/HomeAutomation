// <copyright file="Hosts.cs" company="ContextQuickie">
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
namespace FritzControl.Soap.LANDevice
{
  /// <summary>
  /// Wrapper for the service urn:dslforum-org:service:Hosts:1.
  /// </summary>
  public class Hosts : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:Hosts:1";

    /// <summary>
    /// Wrapper for the action GetHostNumberOfEntries.
    /// </summary>
    /// <returns>The result (NewHostNumberOfEntries) of the action.</returns>
    public ushort GetHostNumberOfEntries()
    {
      return this.SendRequest<ushort>("GetHostNumberOfEntries");
    }

    /// <summary>
    /// Wrapper for the action GetSpecificHostEntry.
    /// </summary>
    /// <param name="newMACAddress">The SOAP parameter NewMACAddress.</param>
    /// <returns>The result (GetSpecificHostEntryResult) of the action.</returns>
    public GetSpecificHostEntryResult GetSpecificHostEntry(string newMACAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewMACAddress", newMACAddress);
      return this.SendRequest<GetSpecificHostEntryResult>("GetSpecificHostEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetGenericHostEntry.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <returns>The result (GetGenericHostEntryResult) of the action.</returns>
    public GetGenericHostEntryResult GetGenericHostEntry(ushort newIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      return this.SendRequest<GetGenericHostEntryResult>("GetGenericHostEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetChangeCounter.
    /// </summary>
    /// <returns>The result (NewX_AVM-DE_ChangeCounter) of the action.</returns>
    public uint X_AVM_DE_GetChangeCounter()
    {
      return this.SendRequest<uint>("X_AVM-DE_GetChangeCounter");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetHostNameByMACAddress.
    /// </summary>
    /// <param name="newMACAddress">The SOAP parameter NewMACAddress.</param>
    /// <param name="newHostName">The SOAP parameter NewHostName.</param>
    public void X_AVM_DE_SetHostNameByMACAddress(string newMACAddress, string newHostName)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewMACAddress", newMACAddress);
      arguments.Add("NewHostName", newHostName);
      this.SendRequest("X_AVM-DE_SetHostNameByMACAddress", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetAutoWakeOnLANByMACAddress.
    /// </summary>
    /// <param name="newMACAddress">The SOAP parameter NewMACAddress.</param>
    /// <returns>The result (NewAutoWOLEnabled) of the action.</returns>
    public bool X_AVM_DE_GetAutoWakeOnLANByMACAddress(string newMACAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewMACAddress", newMACAddress);
      return this.SendRequest<bool>("X_AVM-DE_GetAutoWakeOnLANByMACAddress", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetAutoWakeOnLANByMACAddress.
    /// </summary>
    /// <param name="newMACAddress">The SOAP parameter NewMACAddress.</param>
    /// <param name="newAutoWOLEnabled">The SOAP parameter NewAutoWOLEnabled.</param>
    public void X_AVM_DE_SetAutoWakeOnLANByMACAddress(string newMACAddress, bool newAutoWOLEnabled)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewMACAddress", newMACAddress);
      arguments.Add("NewAutoWOLEnabled", newAutoWOLEnabled);
      this.SendRequest("X_AVM-DE_SetAutoWakeOnLANByMACAddress", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_WakeOnLANByMACAddress.
    /// </summary>
    /// <param name="newMACAddress">The SOAP parameter NewMACAddress.</param>
    public void X_AVM_DE_WakeOnLANByMACAddress(string newMACAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewMACAddress", newMACAddress);
      this.SendRequest("X_AVM-DE_WakeOnLANByMACAddress", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetSpecificHostEntryByIP.
    /// </summary>
    /// <param name="newIPAddress">The SOAP parameter NewIPAddress.</param>
    /// <returns>The result (X_AVM_DE_GetSpecificHostEntryByIPResult) of the action.</returns>
    public X_AVM_DE_GetSpecificHostEntryByIPResult X_AVM_DE_GetSpecificHostEntryByIP(string newIPAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIPAddress", newIPAddress);
      return this.SendRequest<X_AVM_DE_GetSpecificHostEntryByIPResult>("X_AVM-DE_GetSpecificHostEntryByIP", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_HostsCheckUpdate.
    /// </summary>
    public void X_AVM_DE_HostsCheckUpdate()
    {
      this.SendRequest("X_AVM-DE_HostsCheckUpdate");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_HostDoUpdate.
    /// </summary>
    /// <param name="newMACAddress">The SOAP parameter NewMACAddress.</param>
    public void X_AVM_DE_HostDoUpdate(string newMACAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewMACAddress", newMACAddress);
      this.SendRequest("X_AVM-DE_HostDoUpdate", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetHostListPath.
    /// </summary>
    /// <returns>The result (NewX_AVM-DE_HostListPath) of the action.</returns>
    public string X_AVM_DE_GetHostListPath()
    {
      return this.SendRequest<string>("X_AVM-DE_GetHostListPath");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetMeshListPath.
    /// </summary>
    /// <returns>The result (NewX_AVM-DE_MeshListPath) of the action.</returns>
    public string X_AVM_DE_GetMeshListPath()
    {
      return this.SendRequest<string>("X_AVM-DE_GetMeshListPath");
    }
  }
}
