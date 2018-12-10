// <copyright file="SystemVersion.cs" company="ContextQuickie">
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
  /// This class respresents the systemVersion node in a <see cref="Description"/> element.
  /// </summary>
  public class SystemVersion
  {
    /// <summary>
    /// Gets or sets the build number.
    /// </summary>
    [XmlElement("Buildnumber")]
    public int BuildNumber { get; set; }

    /// <summary>
    /// Gets or sets the hardware version.
    /// </summary>
    [XmlElement("HW")]
    public int HardwareVersion { get; set; }

    /// <summary>
    /// Gets or sets the major version.
    /// </summary>
    [XmlElement("Major")]
    public int MajorVersion { get; set; }

    /// <summary>
    /// Gets or sets the minor version.
    /// </summary>
    [XmlElement("Minor")]
    public int MinorVersion { get; set; }

    /// <summary>
    /// Gets or sets the patch version.
    /// </summary>
    [XmlElement("Patch")]
    public int PatchVersion { get; set; }

    /// <summary>
    /// Gets or sets the displayed version.
    /// </summary>
    [XmlElement("Display")]
    public string DisplayedVersion { get; set; }
  }
}
