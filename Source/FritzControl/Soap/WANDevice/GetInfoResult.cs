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
namespace FritzControl.Soap.WANDevice
{
  /// <summary>
  /// Result type for GetInfo.
  /// </summary>
  public class GetInfoResult
  {
    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewEnable is set or not.
    /// </summary>
    public bool NewEnable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewStatus.
    /// </summary>
    public string NewStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDataPath.
    /// </summary>
    public string NewDataPath { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamCurrRate.
    /// </summary>
    public int NewUpstreamCurrRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamCurrRate.
    /// </summary>
    public uint NewDownstreamCurrRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamMaxRate.
    /// </summary>
    public uint NewUpstreamMaxRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamMaxRate.
    /// </summary>
    public uint NewDownstreamMaxRate { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamNoiseMargin.
    /// </summary>
    public uint NewUpstreamNoiseMargin { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamNoiseMargin.
    /// </summary>
    public uint NewDownstreamNoiseMargin { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamAttenuation.
    /// </summary>
    public uint NewUpstreamAttenuation { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamAttenuation.
    /// </summary>
    public uint NewDownstreamAttenuation { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewATURVendor.
    /// </summary>
    public string NewATURVendor { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewATURCountry.
    /// </summary>
    public string NewATURCountry { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpstreamPower.
    /// </summary>
    public ushort NewUpstreamPower { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDownstreamPower.
    /// </summary>
    public ushort NewDownstreamPower { get; set; }
  }
}
