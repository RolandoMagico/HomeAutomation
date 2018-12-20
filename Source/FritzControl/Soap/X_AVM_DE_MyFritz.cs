// <copyright file="X_AVM_DE_MyFritz.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_MyFritz:1.
  /// </summary>
  public class X_AVM_DE_MyFritz : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:X_AVM-DE_MyFritz:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (X_AVM_DE_MyFritzGetInfoResult) of the action.</returns>
    public X_AVM_DE_MyFritzGetInfoResult GetInfo()
    {
      return this.SendRequest<X_AVM_DE_MyFritzGetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action GetNumberOfServices.
    /// </summary>
    /// <returns>The result (NewNumberOfServices) of the action.</returns>
    public uint GetNumberOfServices()
    {
      return this.SendRequest<uint>("GetNumberOfServices");
    }

    /// <summary>
    /// Wrapper for the action GetServiceByIndex.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <returns>The result (X_AVM_DE_MyFritzGetServiceByIndexResult) of the action.</returns>
    public X_AVM_DE_MyFritzGetServiceByIndexResult GetServiceByIndex(uint newIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      return this.SendRequest<X_AVM_DE_MyFritzGetServiceByIndexResult>("GetServiceByIndex", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetServiceByIndex.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <param name="newEnabled">The SOAP parameter NewEnabled.</param>
    /// <param name="newName">The SOAP parameter NewName.</param>
    /// <param name="newScheme">The SOAP parameter NewScheme.</param>
    /// <param name="newPort">The SOAP parameter NewPort.</param>
    /// <param name="newURLPath">The SOAP parameter NewURLPath.</param>
    /// <param name="newType">The SOAP parameter NewType.</param>
    /// <param name="newIPv4Address">The SOAP parameter NewIPv4Address.</param>
    /// <param name="newIPv6Address">The SOAP parameter NewIPv6Address.</param>
    /// <param name="newIPv6InterfaceID">The SOAP parameter NewIPv6InterfaceID.</param>
    /// <param name="newMACAddress">The SOAP parameter NewMACAddress.</param>
    /// <param name="newHostName">The SOAP parameter NewHostName.</param>
    public void SetServiceByIndex(uint newIndex, bool newEnabled, string newName, string newScheme, uint newPort, string newURLPath, string newType, string newIPv4Address, string newIPv6Address, string newIPv6InterfaceID, string newMACAddress, string newHostName)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      arguments.Add("NewEnabled", newEnabled);
      arguments.Add("NewName", newName);
      arguments.Add("NewScheme", newScheme);
      arguments.Add("NewPort", newPort);
      arguments.Add("NewURLPath", newURLPath);
      arguments.Add("NewType", newType);
      arguments.Add("NewIPv4Address", newIPv4Address);
      arguments.Add("NewIPv6Address", newIPv6Address);
      arguments.Add("NewIPv6InterfaceID", newIPv6InterfaceID);
      arguments.Add("NewMACAddress", newMACAddress);
      arguments.Add("NewHostName", newHostName);
      this.SendRequest("SetServiceByIndex", arguments);
    }

    /// <summary>
    /// Wrapper for the action DeleteServiceByIndex.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    public void DeleteServiceByIndex(uint newIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      this.SendRequest("DeleteServiceByIndex", arguments);
    }
  }
}
