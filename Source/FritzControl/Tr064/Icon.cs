// <copyright file="Icon.cs" company="ContextQuickie">
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
namespace FritzControl.Tr064
{
  using System.Xml.Serialization;

  /// <summary>
  /// This class respresents a icon node in a <see cref="Device"/> element.
  /// </summary>
  public class Icon
  {
    /// <summary>
    /// Gets or sets the MIMIE type.
    /// </summary>
    [XmlElement("mimetype")]
    public string MimeType { get; set; }

    /// <summary>
    /// Gets or sets the icon height.
    /// </summary>
    [XmlElement("height")]
    public int Height { get; set; }

    /// <summary>
    /// Gets or sets the icon width.
    /// </summary>
    [XmlElement("width")]
    public int Width { get; set; }

    /// <summary>
    /// Gets or sets the icon color depth.
    /// </summary>
    [XmlElement("depth")]
    public int ColorDepth { get; set; }

    /// <summary>
    /// Gets or sets the icon URL.
    /// </summary>
    [XmlElement("url")]
    public string URL { get; set; }
  }
}
