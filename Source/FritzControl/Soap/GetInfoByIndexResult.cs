// <copyright file="GetInfoByIndexResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfoByIndex.
  /// </summary>
  public class GetInfoByIndexResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewEnable
    /// </summary>
    public bool NewEnable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewStatus
    /// </summary>
    public string NewStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLastConnect
    /// </summary>
    public string NewLastConnect { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUrl
    /// </summary>
    public string NewUrl { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewServiceId
    /// </summary>
    public string NewServiceId { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUsername
    /// </summary>
    public string NewUsername { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewName
    /// </summary>
    public string NewName { get; set; }
  }
}