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
  /// Wrapper for the service urn:dslforum-org:service:LANHostConfigManagement:1
  /// </summary>
  public class LANHostConfigManagement
  {
    /// <summary>
    /// Wrapper for the action GetInfo
    /// </summary>
    public void GetInfo()
    {
    }

    /// <summary>
    /// Wrapper for the action SetDHCPServerEnable
    /// </summary>
    /// <param name="newDHCPServerEnable">The SOAP parameter NewDHCPServerEnable.</param>
    public void SetDHCPServerEnable(bool newDHCPServerEnable)
    {
    }

    /// <summary>
    /// Wrapper for the action SetIPInterface
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    /// <param name="newIPAddress">The SOAP parameter NewIPAddress.</param>
    /// <param name="newSubnetMask">The SOAP parameter NewSubnetMask.</param>
    /// <param name="newIPAddressingType">The SOAP parameter NewIPAddressingType.</param>
    public void SetIPInterface(bool newEnable, string newIPAddress, string newSubnetMask, string newIPAddressingType)
    {
    }

    /// <summary>
    /// Wrapper for the action GetAddressRange
    /// </summary>
    public void GetAddressRange()
    {
    }

    /// <summary>
    /// Wrapper for the action SetAddressRange
    /// </summary>
    /// <param name="newMinAddress">The SOAP parameter NewMinAddress.</param>
    /// <param name="newMaxAddress">The SOAP parameter NewMaxAddress.</param>
    public void SetAddressRange(string newMinAddress, string newMaxAddress)
    {
    }

    /// <summary>
    /// Wrapper for the action GetIPRoutersList
    /// </summary>
    public void GetIPRoutersList()
    {
    }

    /// <summary>
    /// Wrapper for the action SetIPRouter
    /// </summary>
    /// <param name="newIPRouters">The SOAP parameter NewIPRouters.</param>
    public void SetIPRouter(string newIPRouters)
    {
    }

    /// <summary>
    /// Wrapper for the action GetSubnetMask
    /// </summary>
    public void GetSubnetMask()
    {
    }

    /// <summary>
    /// Wrapper for the action SetSubnetMask
    /// </summary>
    /// <param name="newSubnetMask">The SOAP parameter NewSubnetMask.</param>
    public void SetSubnetMask(string newSubnetMask)
    {
    }

    /// <summary>
    /// Wrapper for the action GetDNSServers
    /// </summary>
    public void GetDNSServers()
    {
    }

    /// <summary>
    /// Wrapper for the action GetIPInterfaceNumberOfEntries
    /// </summary>
    public void GetIPInterfaceNumberOfEntries()
    {
    }
  }
}
