// <copyright file="LANHostConfigManagement.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:LANHostConfigManagement:1.
  /// </summary>
  public class LANHostConfigManagement : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:LANHostConfigManagement:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (GetInfoResult) of the action.</returns>
    public GetInfoResult GetInfo()
    {
      return this.SendRequest<GetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action SetDHCPServerEnable.
    /// </summary>
    /// <param name="newDHCPServerEnable">The SOAP parameter NewDHCPServerEnable.</param>
    public void SetDHCPServerEnable(bool newDHCPServerEnable)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDHCPServerEnable", newDHCPServerEnable);
      this.SendRequest("SetDHCPServerEnable", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetIPInterface.
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    /// <param name="newIPAddress">The SOAP parameter NewIPAddress.</param>
    /// <param name="newSubnetMask">The SOAP parameter NewSubnetMask.</param>
    /// <param name="newIPAddressingType">The SOAP parameter NewIPAddressingType.</param>
    public void SetIPInterface(bool newEnable, string newIPAddress, string newSubnetMask, string newIPAddressingType)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewEnable", newEnable);
      arguments.Add("NewIPAddress", newIPAddress);
      arguments.Add("NewSubnetMask", newSubnetMask);
      arguments.Add("NewIPAddressingType", newIPAddressingType);
      this.SendRequest("SetIPInterface", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetAddressRange.
    /// </summary>
    /// <returns>The result (GetAddressRangeResult) of the action.</returns>
    public GetAddressRangeResult GetAddressRange()
    {
      return this.SendRequest<GetAddressRangeResult>("GetAddressRange");
    }

    /// <summary>
    /// Wrapper for the action SetAddressRange.
    /// </summary>
    /// <param name="newMinAddress">The SOAP parameter NewMinAddress.</param>
    /// <param name="newMaxAddress">The SOAP parameter NewMaxAddress.</param>
    public void SetAddressRange(string newMinAddress, string newMaxAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewMinAddress", newMinAddress);
      arguments.Add("NewMaxAddress", newMaxAddress);
      this.SendRequest("SetAddressRange", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetIPRoutersList.
    /// </summary>
    /// <returns>The result (NewIPRouters) of the action.</returns>
    public string GetIPRoutersList()
    {
      return this.SendRequest<string>("GetIPRoutersList");
    }

    /// <summary>
    /// Wrapper for the action SetIPRouter.
    /// </summary>
    /// <param name="newIPRouters">The SOAP parameter NewIPRouters.</param>
    public void SetIPRouter(string newIPRouters)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIPRouters", newIPRouters);
      this.SendRequest("SetIPRouter", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetSubnetMask.
    /// </summary>
    /// <returns>The result (NewSubnetMask) of the action.</returns>
    public string GetSubnetMask()
    {
      return this.SendRequest<string>("GetSubnetMask");
    }

    /// <summary>
    /// Wrapper for the action SetSubnetMask.
    /// </summary>
    /// <param name="newSubnetMask">The SOAP parameter NewSubnetMask.</param>
    public void SetSubnetMask(string newSubnetMask)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewSubnetMask", newSubnetMask);
      this.SendRequest("SetSubnetMask", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetDNSServers.
    /// </summary>
    /// <returns>The result (NewDNSServers) of the action.</returns>
    public string GetDNSServers()
    {
      return this.SendRequest<string>("GetDNSServers");
    }

    /// <summary>
    /// Wrapper for the action GetIPInterfaceNumberOfEntries.
    /// </summary>
    /// <returns>The result (NewIPInterfaceNumberOfEntries) of the action.</returns>
    public ushort GetIPInterfaceNumberOfEntries()
    {
      return this.SendRequest<ushort>("GetIPInterfaceNumberOfEntries");
    }
  }
}
