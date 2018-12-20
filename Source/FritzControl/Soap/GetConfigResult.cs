// <copyright file="GetConfigResult.cs" company="ContextQuickie">
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
  /// Result type for GetConfig.
  /// </summary>
  public class GetConfigResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewConfigRight
    /// </summary>
    public string NewConfigRight { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAppRight
    /// </summary>
    public string NewAppRight { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewNasRight
    /// </summary>
    public string NewNasRight { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPhoneRight
    /// </summary>
    public string NewPhoneRight { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDialRight
    /// </summary>
    public string NewDialRight { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHomeautoRight
    /// </summary>
    public string NewHomeautoRight { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewInternetRights
    /// </summary>
    public bool NewInternetRights { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewAccessFromInternet
    /// </summary>
    public bool NewAccessFromInternet { get; set; }
  }
}
