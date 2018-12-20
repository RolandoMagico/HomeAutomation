// <copyright file="GetSpecificDeviceInfosResult.cs" company="ContextQuickie">
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
  /// Result type for GetSpecificDeviceInfos.
  /// </summary>
  public class GetSpecificDeviceInfosResult
  {
    /// <summary>
    /// Gets or sets the SOAP argument NewDeviceId.
    /// </summary>
    public ushort NewDeviceId { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewFunctionBitMask.
    /// </summary>
    public ushort NewFunctionBitMask { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewFirmwareVersion.
    /// </summary>
    public string NewFirmwareVersion { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewManufacturer.
    /// </summary>
    public string NewManufacturer { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewProductName.
    /// </summary>
    public string NewProductName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewDeviceName.
    /// </summary>
    public string NewDeviceName { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewPresent.
    /// </summary>
    public string NewPresent { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMultimeterIsEnabled.
    /// </summary>
    public string NewMultimeterIsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMultimeterIsValid.
    /// </summary>
    public string NewMultimeterIsValid { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMultimeterPower.
    /// </summary>
    public uint NewMultimeterPower { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewMultimeterEnergy.
    /// </summary>
    public uint NewMultimeterEnergy { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTemperatureIsEnabled.
    /// </summary>
    public string NewTemperatureIsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTemperatureIsValid.
    /// </summary>
    public string NewTemperatureIsValid { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTemperatureCelsius.
    /// </summary>
    public int NewTemperatureCelsius { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewTemperatureOffset.
    /// </summary>
    public int NewTemperatureOffset { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSwitchIsEnabled.
    /// </summary>
    public string NewSwitchIsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSwitchIsValid.
    /// </summary>
    public string NewSwitchIsValid { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSwitchState.
    /// </summary>
    public string NewSwitchState { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewSwitchMode.
    /// </summary>
    public string NewSwitchMode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the SOAP argument NewSwitchLock is set or not.
    /// </summary>
    public bool NewSwitchLock { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrIsEnabled.
    /// </summary>
    public string NewHkrIsEnabled { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrIsValid.
    /// </summary>
    public string NewHkrIsValid { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrIsTemperature.
    /// </summary>
    public int NewHkrIsTemperature { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrSetVentilStatus.
    /// </summary>
    public string NewHkrSetVentilStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrSetTemperature.
    /// </summary>
    public int NewHkrSetTemperature { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrReduceVentilStatus.
    /// </summary>
    public string NewHkrReduceVentilStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrReduceTemperature.
    /// </summary>
    public int NewHkrReduceTemperature { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrComfortVentilStatus.
    /// </summary>
    public string NewHkrComfortVentilStatus { get; set; }

    /// <summary>
    /// Gets or sets the SOAP argument NewHkrComfortTemperature.
    /// </summary>
    public int NewHkrComfortTemperature { get; set; }
  }
}
