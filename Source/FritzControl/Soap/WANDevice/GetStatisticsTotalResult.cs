// <copyright file="GetStatisticsTotalResult.cs" company="ContextQuickie">
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
  /// Result type for GetStatisticsTotal.
  /// </summary>
  public class GetStatisticsTotalResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewReceiveBlocks
    /// </summary>
    public uint NewReceiveBlocks { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTransmitBlocks
    /// </summary>
    public uint NewTransmitBlocks { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewCellDelin
    /// </summary>
    public uint NewCellDelin { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLinkRetrain
    /// </summary>
    public uint NewLinkRetrain { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewInitErrors
    /// </summary>
    public uint NewInitErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewInitTimeouts
    /// </summary>
    public uint NewInitTimeouts { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewLossOfFraming
    /// </summary>
    public uint NewLossOfFraming { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewErroredSecs
    /// </summary>
    public uint NewErroredSecs { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSeverelyErroredSecs
    /// </summary>
    public uint NewSeverelyErroredSecs { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewFECErrors
    /// </summary>
    public uint NewFECErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewATUCFECErrors
    /// </summary>
    public uint NewATUCFECErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHECErrors
    /// </summary>
    public uint NewHECErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewATUCHECErrors
    /// </summary>
    public uint NewATUCHECErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewCRCErrors
    /// </summary>
    public uint NewCRCErrors { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewATUCCRCErrors
    /// </summary>
    public uint NewATUCCRCErrors { get; set; }
  }
}
