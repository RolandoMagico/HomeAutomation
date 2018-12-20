// <copyright file="X_AVM_DE_Homeauto.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_Homeauto:1.
  /// </summary>
  public class X_AVM_DE_Homeauto : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:X_AVM-DE_Homeauto:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (NewAllowedCharsAIN) of the action.</returns>
    public string GetInfo()
    {
      return this.SendRequest<string>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action GetGenericDeviceInfos.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <returns>The result (X_AVM_DE_HomeautoGetGenericDeviceInfosResult) of the action.</returns>
    public X_AVM_DE_HomeautoGetGenericDeviceInfosResult GetGenericDeviceInfos(ushort newIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      return this.SendRequest<X_AVM_DE_HomeautoGetGenericDeviceInfosResult>("GetGenericDeviceInfos", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetSpecificDeviceInfos.
    /// </summary>
    /// <param name="newAIN">The SOAP parameter NewAIN.</param>
    /// <returns>The result (X_AVM_DE_HomeautoGetSpecificDeviceInfosResult) of the action.</returns>
    public X_AVM_DE_HomeautoGetSpecificDeviceInfosResult GetSpecificDeviceInfos(string newAIN)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAIN", newAIN);
      return this.SendRequest<X_AVM_DE_HomeautoGetSpecificDeviceInfosResult>("GetSpecificDeviceInfos", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetSwitch.
    /// </summary>
    /// <param name="newAIN">The SOAP parameter NewAIN.</param>
    /// <param name="newSwitchState">The SOAP parameter NewSwitchState. Allowed values: OFF, ON, TOGGLE, UNDEFINED.</param>
    public void SetSwitch(string newAIN, string newSwitchState)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAIN", newAIN);
      arguments.Add("NewSwitchState", newSwitchState);
      this.SendRequest("SetSwitch", arguments);
    }
  }
}
