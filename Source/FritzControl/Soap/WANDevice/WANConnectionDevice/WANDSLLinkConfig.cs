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
    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (GetInfoResult) of the action.</returns>
    public GetInfoResult GetInfo()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action SetEnable.
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetEnable(bool newEnable)
    {
    }

    /// <summary>
    /// Wrapper for the action GetAutoConfig.
    /// </summary>
    /// <returns>The result (NewAutoConfig) of the action.</returns>
    public bool GetAutoConfig()
    {
      return false;
    }

    /// <summary>
    /// Wrapper for the action SetDSLLinkType.
    /// </summary>
    /// <param name="newLinkType">The SOAP parameter NewLinkType.</param>
    public void SetDSLLinkType(string newLinkType)
    {
    }

    /// <summary>
    /// Wrapper for the action GetDSLLinkInfo.
    /// </summary>
    /// <returns>The result (GetDSLLinkInfoResult) of the action.</returns>
    public GetDSLLinkInfoResult GetDSLLinkInfo()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action SetDestinationAddress.
    /// </summary>
    /// <param name="newDestinationAddress">The SOAP parameter NewDestinationAddress.</param>
    public void SetDestinationAddress(string newDestinationAddress)
    {
    }

    /// <summary>
    /// Wrapper for the action GetDestinationAddress.
    /// </summary>
    /// <returns>The result (NewDestinationAddress) of the action.</returns>
    public string GetDestinationAddress()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action SetATMEncapsulation.
    /// </summary>
    /// <param name="newATMEncapsulation">The SOAP parameter NewATMEncapsulation.</param>
    public void SetATMEncapsulation(string newATMEncapsulation)
    {
    }

    /// <summary>
    /// Wrapper for the action GetATMEncapsulation.
    /// </summary>
    /// <returns>The result (NewATMEncapsulation) of the action.</returns>
    public string GetATMEncapsulation()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action GetStatistics.
    /// </summary>
    /// <returns>The result (GetStatisticsResult) of the action.</returns>
    public GetStatisticsResult GetStatistics()
    {
      return null;
    }
  }
}
