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
namespace FritzControl.Soap
{
  /// <summary>
  /// Result type for GetInfo.
  /// </summary>
  public class GetInfoResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsAppId
    /// </summary>
    public ushort NewMinCharsAppId { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsAppId
    /// </summary>
    public ushort NewMaxCharsAppId { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsAppId
    /// </summary>
    public string NewAllowedCharsAppId { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsAppDisplayName
    /// </summary>
    public ushort NewMinCharsAppDisplayName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsAppDisplayName
    /// </summary>
    public ushort NewMaxCharsAppDisplayName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsAppUsername
    /// </summary>
    public ushort NewMinCharsAppUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsAppUsername
    /// </summary>
    public ushort NewMaxCharsAppUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsAppUsername
    /// </summary>
    public string NewAllowedCharsAppUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsAppPassword
    /// </summary>
    public ushort NewMinCharsAppPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsAppPassword
    /// </summary>
    public ushort NewMaxCharsAppPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsAppPassword
    /// </summary>
    public string NewAllowedCharsAppPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsIPSecIdentifier
    /// </summary>
    public ushort NewMinCharsIPSecIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsIPSecIdentifier
    /// </summary>
    public ushort NewMaxCharsIPSecIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsIPSecIdentifier
    /// </summary>
    public string NewAllowedCharsIPSecIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsCryptAlgos
    /// </summary>
    public string NewAllowedCharsCryptAlgos { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsAppAVMAddress
    /// </summary>
    public string NewAllowedCharsAppAVMAddress { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsFilter
    /// </summary>
    public ushort NewMinCharsFilter { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsFilter
    /// </summary>
    public ushort NewMaxCharsFilter { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsFilter
    /// </summary>
    public string NewAllowedCharsFilter { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsIPSecPreSharedKey
    /// </summary>
    public ushort NewMinCharsIPSecPreSharedKey { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsIPSecPreSharedKey
    /// </summary>
    public ushort NewMaxCharsIPSecPreSharedKey { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsIPSecPreSharedKey
    /// </summary>
    public string NewAllowedCharsIPSecPreSharedKey { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsIPSecXauthUsername
    /// </summary>
    public ushort NewMinCharsIPSecXauthUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsIPSecXauthUsername
    /// </summary>
    public ushort NewMaxCharsIPSecXauthUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsIPSecXauthUsername
    /// </summary>
    public string NewAllowedCharsIPSecXauthUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMinCharsIPSecXauthPassword
    /// </summary>
    public ushort NewMinCharsIPSecXauthPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMaxCharsIPSecXauthPassword
    /// </summary>
    public ushort NewMaxCharsIPSecXauthPassword { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAllowedCharsIPSecXauthPassword
    /// </summary>
    public string NewAllowedCharsIPSecXauthPassword { get; set; }
  }
}
