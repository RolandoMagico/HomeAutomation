// <copyright file="X_AVM_DE_RemoteAccess.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1.
  /// </summary>
  public class X_AVM_DE_RemoteAccess : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:X_AVM-DE_RemoteAccess:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (GetInfoResult) of the action.</returns>
    public GetInfoResult GetInfo()
    {
      return this.SendRequest<GetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action SetConfig.
    /// </summary>
    /// <param name="newEnabled">The SOAP parameter NewEnabled.</param>
    /// <param name="newPort">The SOAP parameter NewPort.</param>
    /// <param name="newUsername">The SOAP parameter NewUsername.</param>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    public void SetConfig(bool newEnabled, string newPort, string newUsername, string newPassword)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewEnabled", newEnabled);
      arguments.Add("NewPort", newPort);
      arguments.Add("NewUsername", newUsername);
      arguments.Add("NewPassword", newPassword);
      this.SendRequest("SetConfig", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetEnable.
    /// </summary>
    /// <param name="newEnabled">The SOAP parameter NewEnabled.</param>
    /// <returns>The result (NewPort) of the action.</returns>
    public string SetEnable(bool newEnabled)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewEnabled", newEnabled);
      return this.SendRequest<string>("SetEnable", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetDDNSInfo.
    /// </summary>
    /// <returns>The result (GetDDNSInfoResult) of the action.</returns>
    public GetDDNSInfoResult GetDDNSInfo()
    {
      return this.SendRequest<GetDDNSInfoResult>("GetDDNSInfo");
    }

    /// <summary>
    /// Wrapper for the action GetDDNSProviders.
    /// </summary>
    /// <returns>The result (NewProviderList) of the action.</returns>
    public string GetDDNSProviders()
    {
      return this.SendRequest<string>("GetDDNSProviders");
    }

    /// <summary>
    /// Wrapper for the action SetDDNSConfig.
    /// </summary>
    /// <param name="newEnabled">The SOAP parameter NewEnabled.</param>
    /// <param name="newProviderName">The SOAP parameter NewProviderName.</param>
    /// <param name="newUpdateURL">The SOAP parameter NewUpdateURL.</param>
    /// <param name="newDomain">The SOAP parameter NewDomain.</param>
    /// <param name="newUsername">The SOAP parameter NewUsername.</param>
    /// <param name="newMode">The SOAP parameter NewMode.</param>
    /// <param name="newServerIPv4">The SOAP parameter NewServerIPv4.</param>
    /// <param name="newServerIPv6">The SOAP parameter NewServerIPv6.</param>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    public void SetDDNSConfig(bool newEnabled, string newProviderName, string newUpdateURL, string newDomain, string newUsername, string newMode, string newServerIPv4, string newServerIPv6, string newPassword)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewEnabled", newEnabled);
      arguments.Add("NewProviderName", newProviderName);
      arguments.Add("NewUpdateURL", newUpdateURL);
      arguments.Add("NewDomain", newDomain);
      arguments.Add("NewUsername", newUsername);
      arguments.Add("NewMode", newMode);
      arguments.Add("NewServerIPv4", newServerIPv4);
      arguments.Add("NewServerIPv6", newServerIPv6);
      arguments.Add("NewPassword", newPassword);
      this.SendRequest("SetDDNSConfig", arguments);
    }
  }
}
