// <copyright file="LANEthernetInterfaceConfig.cs" company="ContextQuickie">
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
namespace FritzControl.Soap.LANDevice
{
  /// <summary>
  /// Wrapper for the service urn:dslforum-org:service:LANEthernetInterfaceConfig:1.
  /// </summary>
  public class LANEthernetInterfaceConfig : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:LANEthernetInterfaceConfig:1";

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
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (GetInfoResult) of the action.</returns>
    public GetInfoResult GetInfo()
    {
      return this.SendRequest<GetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action GetStatistics.
    /// </summary>
    /// <returns>The result (GetStatisticsResult) of the action.</returns>
    public GetStatisticsResult GetStatistics()
    {
      return this.SendRequest<GetStatisticsResult>("GetStatistics");
    }
  }
}
