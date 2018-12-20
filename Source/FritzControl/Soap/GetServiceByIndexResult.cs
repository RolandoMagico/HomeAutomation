// <copyright file="GetServiceByIndexResult.cs" company="ContextQuickie">
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
  /// Result type for GetServiceByIndex.
  /// </summary>
  public class GetServiceByIndexResult
  {
    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewEnabled is set or not.
    /// </summary>
    public bool NewEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewName.
    /// </summary>
    public string NewName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewScheme.
    /// </summary>
    public string NewScheme { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPort.
    /// </summary>
    public uint NewPort { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewURLPath.
    /// </summary>
    public string NewURLPath { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewType.
    /// </summary>
    public string NewType { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewIPv4ForwardingWarning.
    /// </summary>
    public byte NewIPv4ForwardingWarning { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewIPv4Addresses.
    /// </summary>
    public string NewIPv4Addresses { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewIPv6Addresses.
    /// </summary>
    public string NewIPv6Addresses { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewIPv6InterfaceIDs.
    /// </summary>
    public string NewIPv6InterfaceIDs { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMACAddress.
    /// </summary>
    public string NewMACAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHostName.
    /// </summary>
    public string NewHostName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDynDnsLabel.
    /// </summary>
    public string NewDynDnsLabel { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewStatus.
    /// </summary>
    public uint NewStatus { get; set; }
  }
}
