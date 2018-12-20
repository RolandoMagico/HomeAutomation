// <copyright file="X_AVM_DE_HomeautoGetGenericDeviceInfosResult.cs" company="ContextQuickie">
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
  /// Result type for GetGenericDeviceInfos in service X_AVM_DE_Homeauto.
  /// </summary>
  public class X_AVM_DE_HomeautoGetGenericDeviceInfosResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewAIN.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewAIN")]
    public string NewAIN { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDeviceId.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDeviceId")]
    public ushort NewDeviceId { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewFunctionBitMask.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewFunctionBitMask")]
    public ushort NewFunctionBitMask { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewFirmwareVersion.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewFirmwareVersion")]
    public string NewFirmwareVersion { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewManufacturer.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewManufacturer")]
    public string NewManufacturer { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewProductName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewProductName")]
    public string NewProductName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDeviceName.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewDeviceName")]
    public string NewDeviceName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPresent.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewPresent")]
    public string NewPresent { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMultimeterIsEnabled.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMultimeterIsEnabled")]
    public string NewMultimeterIsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMultimeterIsValid.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMultimeterIsValid")]
    public string NewMultimeterIsValid { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMultimeterPower.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMultimeterPower")]
    public uint NewMultimeterPower { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMultimeterEnergy.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewMultimeterEnergy")]
    public uint NewMultimeterEnergy { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTemperatureIsEnabled.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewTemperatureIsEnabled")]
    public string NewTemperatureIsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTemperatureIsValid.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewTemperatureIsValid")]
    public string NewTemperatureIsValid { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTemperatureCelsius.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewTemperatureCelsius")]
    public int NewTemperatureCelsius { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTemperatureOffset.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewTemperatureOffset")]
    public int NewTemperatureOffset { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSwitchIsEnabled.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSwitchIsEnabled")]
    public string NewSwitchIsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSwitchIsValid.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSwitchIsValid")]
    public string NewSwitchIsValid { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSwitchState.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSwitchState")]
    public string NewSwitchState { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSwitchMode.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSwitchMode")]
    public string NewSwitchMode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewSwitchLock is set or not.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewSwitchLock")]
    public bool NewSwitchLock { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrIsEnabled.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHkrIsEnabled")]
    public string NewHkrIsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrIsValid.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHkrIsValid")]
    public string NewHkrIsValid { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrIsTemperature.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHkrIsTemperature")]
    public int NewHkrIsTemperature { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrSetVentilStatus.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHkrSetVentilStatus")]
    public string NewHkrSetVentilStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrSetTemperature.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHkrSetTemperature")]
    public int NewHkrSetTemperature { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrReduceVentilStatus.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHkrReduceVentilStatus")]
    public string NewHkrReduceVentilStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrReduceTemperature.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHkrReduceTemperature")]
    public int NewHkrReduceTemperature { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrComfortVentilStatus.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHkrComfortVentilStatus")]
    public string NewHkrComfortVentilStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrComfortTemperature.
    /// </summary>
    [System.Xml.Serialization.XmlElement("NewHkrComfortTemperature")]
    public int NewHkrComfortTemperature { get; set; }
  }
}
