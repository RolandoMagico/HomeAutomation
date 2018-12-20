// <copyright file="GetDDNSInfoResult.cs" company="ContextQuickie">
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
  /// Result type for GetDDNSInfo.
  /// </summary>
  public class GetDDNSInfoResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewEnabled
    /// </summary>
    public bool NewEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewProviderName
    /// </summary>
    public string NewProviderName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpdateURL
    /// </summary>
    public string NewUpdateURL { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDomain
    /// </summary>
    public string NewDomain { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewStatusIPv4
    /// </summary>
    public string NewStatusIPv4 { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewStatusIPv6
    /// </summary>
    public string NewStatusIPv6 { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUsername
    /// </summary>
    public string NewUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMode
    /// </summary>
    public string NewMode { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewServerIPv4
    /// </summary>
    public string NewServerIPv4 { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewServerIPv6
    /// </summary>
    public string NewServerIPv6 { get; set; }
  }
}
