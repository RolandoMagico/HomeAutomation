// <copyright file="WANDSLLinkConfig.cs" company="ContextQuickie">
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
namespace FritzControl.Soap.WANDevice.WANConnectionDevice
{
  /// <summary>
  /// Wrapper for the service urn:dslforum-org:service:WANDSLLinkConfig:1.
  /// </summary>
  public class WANDSLLinkConfig : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:WANDSLLinkConfig:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (WANDSLLinkConfigGetInfoResult) of the action.</returns>
    public WANDSLLinkConfigGetInfoResult GetInfo()
    {
      return this.SendRequest<WANDSLLinkConfigGetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action SetEnable.
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetEnable(bool newEnable)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewEnable", newEnable);
      this.SendRequest("SetEnable", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetAutoConfig.
    /// </summary>
    /// <returns>The result (NewAutoConfig) of the action.</returns>
    public bool GetAutoConfig()
    {
      return this.SendRequest<bool>("GetAutoConfig");
    }

    /// <summary>
    /// Wrapper for the action SetDSLLinkType.
    /// </summary>
    /// <param name="newLinkType">The SOAP parameter NewLinkType. Allowed values: EoA, PPPoA, PPPoE, Unconfigured.</param>
    public void SetDSLLinkType(string newLinkType)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewLinkType", newLinkType);
      this.SendRequest("SetDSLLinkType", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetDSLLinkInfo.
    /// </summary>
    /// <returns>The result (WANDSLLinkConfigGetDSLLinkInfoResult) of the action.</returns>
    public WANDSLLinkConfigGetDSLLinkInfoResult GetDSLLinkInfo()
    {
      return this.SendRequest<WANDSLLinkConfigGetDSLLinkInfoResult>("GetDSLLinkInfo");
    }

    /// <summary>
    /// Wrapper for the action SetDestinationAddress.
    /// </summary>
    /// <param name="newDestinationAddress">The SOAP parameter NewDestinationAddress.</param>
    public void SetDestinationAddress(string newDestinationAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDestinationAddress", newDestinationAddress);
      this.SendRequest("SetDestinationAddress", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetDestinationAddress.
    /// </summary>
    /// <returns>The result (NewDestinationAddress) of the action.</returns>
    public string GetDestinationAddress()
    {
      return this.SendRequest<string>("GetDestinationAddress");
    }

    /// <summary>
    /// Wrapper for the action SetATMEncapsulation.
    /// </summary>
    /// <param name="newATMEncapsulation">The SOAP parameter NewATMEncapsulation. Allowed values: LLC, VCMUX.</param>
    public void SetATMEncapsulation(string newATMEncapsulation)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewATMEncapsulation", newATMEncapsulation);
      this.SendRequest("SetATMEncapsulation", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetATMEncapsulation.
    /// </summary>
    /// <returns>The result (NewATMEncapsulation) of the action.</returns>
    public string GetATMEncapsulation()
    {
      return this.SendRequest<string>("GetATMEncapsulation");
    }

    /// <summary>
    /// Wrapper for the action GetStatistics.
    /// </summary>
    /// <returns>The result (WANDSLLinkConfigGetStatisticsResult) of the action.</returns>
    public WANDSLLinkConfigGetStatisticsResult GetStatistics()
    {
      return this.SendRequest<WANDSLLinkConfigGetStatisticsResult>("GetStatistics");
    }
  }
}
