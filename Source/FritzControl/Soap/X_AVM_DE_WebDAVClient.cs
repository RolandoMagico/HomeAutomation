// <copyright file="X_AVM_DE_WebDAVClient.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_WebDAVClient:1.
  /// </summary>
  public class X_AVM_DE_WebDAVClient : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:X_AVM-DE_WebDAVClient:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (X_AVM_DE_WebDAVClientGetInfoResult) of the action.</returns>
    public X_AVM_DE_WebDAVClientGetInfoResult GetInfo()
    {
      return this.SendRequest<X_AVM_DE_WebDAVClientGetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action SetConfig.
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    /// <param name="newHostURL">The SOAP parameter NewHostURL.</param>
    /// <param name="newUsername">The SOAP parameter NewUsername.</param>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    /// <param name="newMountpointName">The SOAP parameter NewMountpointName.</param>
    public void SetConfig(bool newEnable, string newHostURL, string newUsername, string newPassword, string newMountpointName)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewEnable", newEnable);
      arguments.Add("NewHostURL", newHostURL);
      arguments.Add("NewUsername", newUsername);
      arguments.Add("NewPassword", newPassword);
      arguments.Add("NewMountpointName", newMountpointName);
      this.SendRequest("SetConfig", arguments);
    }
  }
}
