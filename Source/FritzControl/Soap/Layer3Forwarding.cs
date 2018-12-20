// <copyright file="Layer3Forwarding.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:Layer3Forwarding:1.
  /// </summary>
  public class Layer3Forwarding : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:Layer3Forwarding:1";

    /// <summary>
    /// Wrapper for the action SetDefaultConnectionService.
    /// </summary>
    /// <param name="newDefaultConnectionService">The SOAP parameter NewDefaultConnectionService.</param>
    public void SetDefaultConnectionService(string newDefaultConnectionService)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDefaultConnectionService", newDefaultConnectionService);
      this.SendRequest("SetDefaultConnectionService", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetDefaultConnectionService.
    /// </summary>
    /// <returns>The result (NewDefaultConnectionService) of the action.</returns>
    public string GetDefaultConnectionService()
    {
      return this.SendRequest<string>("GetDefaultConnectionService");
    }

    /// <summary>
    /// Wrapper for the action GetForwardNumberOfEntries.
    /// </summary>
    /// <returns>The result (NewForwardNumberOfEntries) of the action.</returns>
    public ushort GetForwardNumberOfEntries()
    {
      return this.SendRequest<ushort>("GetForwardNumberOfEntries");
    }

    /// <summary>
    /// Wrapper for the action AddForwardingEntry.
    /// </summary>
    /// <param name="newType">The SOAP parameter NewType.</param>
    /// <param name="newDestIPAddress">The SOAP parameter NewDestIPAddress.</param>
    /// <param name="newDestSubnetMask">The SOAP parameter NewDestSubnetMask.</param>
    /// <param name="newSourceIPAddress">The SOAP parameter NewSourceIPAddress.</param>
    /// <param name="newSourceSubnetMask">The SOAP parameter NewSourceSubnetMask.</param>
    /// <param name="newGatewayIPAddress">The SOAP parameter NewGatewayIPAddress.</param>
    /// <param name="newInterface">The SOAP parameter NewInterface.</param>
    /// <param name="newForwardingMetric">The SOAP parameter NewForwardingMetric.</param>
    public void AddForwardingEntry(string newType, string newDestIPAddress, string newDestSubnetMask, string newSourceIPAddress, string newSourceSubnetMask, string newGatewayIPAddress, string newInterface, int newForwardingMetric)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewType", newType);
      arguments.Add("NewDestIPAddress", newDestIPAddress);
      arguments.Add("NewDestSubnetMask", newDestSubnetMask);
      arguments.Add("NewSourceIPAddress", newSourceIPAddress);
      arguments.Add("NewSourceSubnetMask", newSourceSubnetMask);
      arguments.Add("NewGatewayIPAddress", newGatewayIPAddress);
      arguments.Add("NewInterface", newInterface);
      arguments.Add("NewForwardingMetric", newForwardingMetric);
      this.SendRequest("AddForwardingEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action DeleteForwardingEntry.
    /// </summary>
    /// <param name="newDestIPAddress">The SOAP parameter NewDestIPAddress.</param>
    /// <param name="newDestSubnetMask">The SOAP parameter NewDestSubnetMask.</param>
    /// <param name="newSourceIPAddress">The SOAP parameter NewSourceIPAddress.</param>
    /// <param name="newSourceSubnetMask">The SOAP parameter NewSourceSubnetMask.</param>
    public void DeleteForwardingEntry(string newDestIPAddress, string newDestSubnetMask, string newSourceIPAddress, string newSourceSubnetMask)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDestIPAddress", newDestIPAddress);
      arguments.Add("NewDestSubnetMask", newDestSubnetMask);
      arguments.Add("NewSourceIPAddress", newSourceIPAddress);
      arguments.Add("NewSourceSubnetMask", newSourceSubnetMask);
      this.SendRequest("DeleteForwardingEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetSpecificForwardingEntry.
    /// </summary>
    /// <param name="newDestIPAddress">The SOAP parameter NewDestIPAddress.</param>
    /// <param name="newDestSubnetMask">The SOAP parameter NewDestSubnetMask.</param>
    /// <param name="newSourceIPAddress">The SOAP parameter NewSourceIPAddress.</param>
    /// <param name="newSourceSubnetMask">The SOAP parameter NewSourceSubnetMask.</param>
    /// <returns>The result (Layer3ForwardingGetSpecificForwardingEntryResult) of the action.</returns>
    public Layer3ForwardingGetSpecificForwardingEntryResult GetSpecificForwardingEntry(string newDestIPAddress, string newDestSubnetMask, string newSourceIPAddress, string newSourceSubnetMask)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDestIPAddress", newDestIPAddress);
      arguments.Add("NewDestSubnetMask", newDestSubnetMask);
      arguments.Add("NewSourceIPAddress", newSourceIPAddress);
      arguments.Add("NewSourceSubnetMask", newSourceSubnetMask);
      return this.SendRequest<Layer3ForwardingGetSpecificForwardingEntryResult>("GetSpecificForwardingEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetGenericForwardingEntry.
    /// </summary>
    /// <param name="newForwardingIndex">The SOAP parameter NewForwardingIndex.</param>
    /// <returns>The result (Layer3ForwardingGetGenericForwardingEntryResult) of the action.</returns>
    public Layer3ForwardingGetGenericForwardingEntryResult GetGenericForwardingEntry(ushort newForwardingIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewForwardingIndex", newForwardingIndex);
      return this.SendRequest<Layer3ForwardingGetGenericForwardingEntryResult>("GetGenericForwardingEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetForwardingEntryEnable.
    /// </summary>
    /// <param name="newDestIPAddress">The SOAP parameter NewDestIPAddress.</param>
    /// <param name="newDestSubnetMask">The SOAP parameter NewDestSubnetMask.</param>
    /// <param name="newSourceIPAddress">The SOAP parameter NewSourceIPAddress.</param>
    /// <param name="newSourceSubnetMask">The SOAP parameter NewSourceSubnetMask.</param>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetForwardingEntryEnable(string newDestIPAddress, string newDestSubnetMask, string newSourceIPAddress, string newSourceSubnetMask, bool newEnable)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDestIPAddress", newDestIPAddress);
      arguments.Add("NewDestSubnetMask", newDestSubnetMask);
      arguments.Add("NewSourceIPAddress", newSourceIPAddress);
      arguments.Add("NewSourceSubnetMask", newSourceSubnetMask);
      arguments.Add("NewEnable", newEnable);
      this.SendRequest("SetForwardingEntryEnable", arguments);
    }
  }
}
