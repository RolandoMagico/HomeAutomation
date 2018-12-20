// <copyright file="GetSpecificDeviceEntryResult.cs" company="ContextQuickie">
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
  /// Result type for GetSpecificDeviceEntry.
  /// </summary>
  public class GetSpecificDeviceEntryResult
  {
    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewActive is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewActive")]
    public bool NewActive { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewName")]
    public string NewName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewModel.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewModel")]
    public string NewModel { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewUpdateAvailable is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpdateAvailable")]
    public bool NewUpdateAvailable { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpdateSuccessful.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpdateSuccessful")]
    public string NewUpdateSuccessful { get; set; }
  }
}
