// <copyright file="X_AVM_DE_Storage.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_Storage:1.
  /// </summary>
  public class X_AVM_DE_Storage
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
    /// Wrapper for the action RequestFTPServerWAN.
    /// </summary>
    /// <returns>The result (RequestFTPServerWANResult) of the action.</returns>
    public RequestFTPServerWANResult RequestFTPServerWAN()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action SetFTPServer.
    /// </summary>
    /// <param name="newFTPEnable">The SOAP parameter NewFTPEnable.</param>
    public void SetFTPServer(bool newFTPEnable)
    {
    }

    /// <summary>
    /// Wrapper for the action SetFTPServerWAN.
    /// </summary>
    /// <param name="newFTPWANEnable">The SOAP parameter NewFTPWANEnable.</param>
    /// <param name="newFTPWANSSLOnly">The SOAP parameter NewFTPWANSSLOnly.</param>
    public void SetFTPServerWAN(bool newFTPWANEnable, bool newFTPWANSSLOnly)
    {
    }

    /// <summary>
    /// Wrapper for the action SetSMBServer.
    /// </summary>
    /// <param name="newSMBEnable">The SOAP parameter NewSMBEnable.</param>
    public void SetSMBServer(bool newSMBEnable)
    {
    }

    /// <summary>
    /// Wrapper for the action GetUserInfo.
    /// </summary>
    /// <returns>The result (GetUserInfoResult) of the action.</returns>
    public GetUserInfoResult GetUserInfo()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action SetUserConfig.
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    /// <param name="newX_AVM_DE_NetworkAccessReadOnly">The SOAP parameter NewX_AVM-DE_NetworkAccessReadOnly.</param>
    public void SetUserConfig(bool newEnable, string newPassword, bool newX_AVM_DE_NetworkAccessReadOnly)
    {
    }
  }
}
