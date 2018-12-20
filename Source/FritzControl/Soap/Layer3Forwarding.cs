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
  /// Wrapper for the service urn:dslforum-org:service:Layer3Forwarding:1
  /// </summary>
  public class Layer3Forwarding
  {
    /// <summary>
    /// Wrapper for the action SetDefaultConnectionService
    /// </summary>
    /// <param name="newDefaultConnectionService">The SOAP parameter NewDefaultConnectionService.</param>
    public void SetDefaultConnectionService(string newDefaultConnectionService)
    {
    }

    /// <summary>
    /// Wrapper for the action GetDefaultConnectionService
    /// </summary>
    public void GetDefaultConnectionService()
    {
    }

    /// <summary>
    /// Wrapper for the action GetForwardNumberOfEntries
    /// </summary>
    public void GetForwardNumberOfEntries()
    {
    }

    /// <summary>
    /// Wrapper for the action AddForwardingEntry
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
    }

    /// <summary>
    /// Wrapper for the action DeleteForwardingEntry
    /// </summary>
    /// <param name="newDestIPAddress">The SOAP parameter NewDestIPAddress.</param>
    /// <param name="newDestSubnetMask">The SOAP parameter NewDestSubnetMask.</param>
    /// <param name="newSourceIPAddress">The SOAP parameter NewSourceIPAddress.</param>
    /// <param name="newSourceSubnetMask">The SOAP parameter NewSourceSubnetMask.</param>
    public void DeleteForwardingEntry(string newDestIPAddress, string newDestSubnetMask, string newSourceIPAddress, string newSourceSubnetMask)
    {
    }

    /// <summary>
    /// Wrapper for the action GetSpecificForwardingEntry
    /// </summary>
    /// <param name="newDestIPAddress">The SOAP parameter NewDestIPAddress.</param>
    /// <param name="newDestSubnetMask">The SOAP parameter NewDestSubnetMask.</param>
    /// <param name="newSourceIPAddress">The SOAP parameter NewSourceIPAddress.</param>
    /// <param name="newSourceSubnetMask">The SOAP parameter NewSourceSubnetMask.</param>
    public void GetSpecificForwardingEntry(string newDestIPAddress, string newDestSubnetMask, string newSourceIPAddress, string newSourceSubnetMask)
    {
    }

    /// <summary>
    /// Wrapper for the action GetGenericForwardingEntry
    /// </summary>
    /// <param name="newForwardingIndex">The SOAP parameter NewForwardingIndex.</param>
    public void GetGenericForwardingEntry(ushort newForwardingIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action SetForwardingEntryEnable
    /// </summary>
    /// <param name="newDestIPAddress">The SOAP parameter NewDestIPAddress.</param>
    /// <param name="newDestSubnetMask">The SOAP parameter NewDestSubnetMask.</param>
    /// <param name="newSourceIPAddress">The SOAP parameter NewSourceIPAddress.</param>
    /// <param name="newSourceSubnetMask">The SOAP parameter NewSourceSubnetMask.</param>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetForwardingEntryEnable(string newDestIPAddress, string newDestSubnetMask, string newSourceIPAddress, string newSourceSubnetMask, bool newEnable)
    {
    }
  }
}
