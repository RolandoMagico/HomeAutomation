// <copyright file="GetInfoResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfo.
  /// </summary>
  public class GetInfoResult
  {
    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewDHCPServerConfigurable is set or not.
    /// </summary>
    public bool NewDHCPServerConfigurable { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewDHCPRelay is set or not.
    /// </summary>
    public bool NewDHCPRelay { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinAddress.
    /// </summary>
    public string NewMinAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxAddress.
    /// </summary>
    public string NewMaxAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewReservedAddresses.
    /// </summary>
    public string NewReservedAddresses { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewDHCPServerEnable is set or not.
    /// </summary>
    public bool NewDHCPServerEnable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDNSServers.
    /// </summary>
    public string NewDNSServers { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDomainName.
    /// </summary>
    public string NewDomainName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewIPRouters.
    /// </summary>
    public string NewIPRouters { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSubnetMask.
    /// </summary>
    public string NewSubnetMask { get; set; }
  }
}
