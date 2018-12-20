// <copyright file="GetGenericPortMappingEntryResult.cs" company="ContextQuickie">
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
namespace FritzControl.Soap.WANDevice.WANConnectionDevice
{
  /// <summary>
  /// Result type for GetGenericPortMappingEntry.
  /// </summary>
  public class GetGenericPortMappingEntryResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewRemoteHost
    /// </summary>
    public string NewRemoteHost { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewExternalPort
    /// </summary>
    public ushort NewExternalPort { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewProtocol
    /// </summary>
    public string NewProtocol { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewInternalPort
    /// </summary>
    public ushort NewInternalPort { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewInternalClient
    /// </summary>
    public string NewInternalClient { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewEnabled
    /// </summary>
    public bool NewEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPortMappingDescription
    /// </summary>
    public string NewPortMappingDescription { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLeaseDuration
    /// </summary>
    public uint NewLeaseDuration { get; set; }
  }
}
