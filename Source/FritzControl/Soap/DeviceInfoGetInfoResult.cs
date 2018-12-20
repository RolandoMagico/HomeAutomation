// <copyright file="DeviceInfoGetInfoResult.cs" company="ContextQuickie">
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
  /// Result type for GetInfo in service DeviceInfo.
  /// </summary>
  public class DeviceInfoGetInfoResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewManufacturerName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewManufacturerName")]
    public string NewManufacturerName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewManufacturerOUI.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewManufacturerOUI")]
    public string NewManufacturerOUI { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewModelName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewModelName")]
    public string NewModelName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDescription.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDescription")]
    public string NewDescription { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewProductClass.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewProductClass")]
    public string NewProductClass { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSerialNumber.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSerialNumber")]
    public string NewSerialNumber { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSoftwareVersion.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSoftwareVersion")]
    public string NewSoftwareVersion { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHardwareVersion.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHardwareVersion")]
    public string NewHardwareVersion { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSpecVersion.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSpecVersion")]
    public string NewSpecVersion { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewProvisioningCode.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewProvisioningCode")]
    public string NewProvisioningCode { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewUpTime.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewUpTime")]
    public uint NewUpTime { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDeviceLog.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDeviceLog")]
    public string NewDeviceLog { get; set; }
  }
}
