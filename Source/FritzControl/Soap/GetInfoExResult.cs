// <copyright file="GetInfoExResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfoEx.
  /// </summary>
  public class GetInfoExResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPNumberMinChars.
    /// </summary>
    public ushort NewVoIPNumberMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPNumberMaxChars.
    /// </summary>
    public ushort NewVoIPNumberMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPNumberAllowedChars.
    /// </summary>
    public string NewVoIPNumberAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPUsernameMinChars.
    /// </summary>
    public ushort NewVoIPUsernameMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPUsernameMaxChars.
    /// </summary>
    public ushort NewVoIPUsernameMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPUsernameAllowedChars.
    /// </summary>
    public string NewVoIPUsernameAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPPasswordMinChars.
    /// </summary>
    public ushort NewVoIPPasswordMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPPasswordMaxChars.
    /// </summary>
    public ushort NewVoIPPasswordMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPPasswordAllowedChars.
    /// </summary>
    public string NewVoIPPasswordAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPRegistrarMinChars.
    /// </summary>
    public ushort NewVoIPRegistrarMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPRegistrarMaxChars.
    /// </summary>
    public ushort NewVoIPRegistrarMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPRegistrarAllowedChars.
    /// </summary>
    public string NewVoIPRegistrarAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPSTUNServerMinChars.
    /// </summary>
    public ushort NewVoIPSTUNServerMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPSTUNServerMaxChars.
    /// </summary>
    public ushort NewVoIPSTUNServerMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewVoIPSTUNServerAllowedChars.
    /// </summary>
    public string NewVoIPSTUNServerAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientUsernameMinChars.
    /// </summary>
    public ushort NewX_AVM_DE_ClientUsernameMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientUsernameMaxChars.
    /// </summary>
    public ushort NewX_AVM_DE_ClientUsernameMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientUsernameAllowedChars.
    /// </summary>
    public string NewX_AVM_DE_ClientUsernameAllowedChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientPasswordMinChars.
    /// </summary>
    public ushort NewX_AVM_DE_ClientPasswordMinChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientPasswordMaxChars.
    /// </summary>
    public ushort NewX_AVM_DE_ClientPasswordMaxChars { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewX_AVM-DE_ClientPasswordAllowedChars.
    /// </summary>
    public string NewX_AVM_DE_ClientPasswordAllowedChars { get; set; }
  }
}
