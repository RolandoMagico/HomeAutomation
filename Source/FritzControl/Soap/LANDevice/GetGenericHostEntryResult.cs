// <copyright file="GetGenericHostEntryResult.cs" company="ContextQuickie">
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
  /// Result type for GetGenericHostEntry.
  /// </summary>
  public class GetGenericHostEntryResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewIPAddress
    /// </summary>
    public string NewIPAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAddressSource
    /// </summary>
    public string NewAddressSource { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLeaseTimeRemaining
    /// </summary>
    public int NewLeaseTimeRemaining { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMACAddress
    /// </summary>
    public string NewMACAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewInterfaceType
    /// </summary>
    public string NewInterfaceType { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewActive
    /// </summary>
    public bool NewActive { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHostName
    /// </summary>
    public string NewHostName { get; set; }
  }
}