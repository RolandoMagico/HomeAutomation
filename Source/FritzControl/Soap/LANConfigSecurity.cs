// <copyright file="LANConfigSecurity.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:LANConfigSecurity:1.
  /// </summary>
  public class LANConfigSecurity : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:LANConfigSecurity:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (GetInfoResult) of the action.</returns>
    public GetInfoResult GetInfo()
    {
      return this.SendRequest<GetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetCurrentUser.
    /// </summary>
    /// <returns>The result (X_AVM_DE_GetCurrentUserResult) of the action.</returns>
    public X_AVM_DE_GetCurrentUserResult X_AVM_DE_GetCurrentUser()
    {
      return this.SendRequest<X_AVM_DE_GetCurrentUserResult>("X_AVM-DE_GetCurrentUser");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetAnonymousLogin.
    /// </summary>
    /// <returns>The result (X_AVM_DE_GetAnonymousLoginResult) of the action.</returns>
    public X_AVM_DE_GetAnonymousLoginResult X_AVM_DE_GetAnonymousLogin()
    {
      return this.SendRequest<X_AVM_DE_GetAnonymousLoginResult>("X_AVM-DE_GetAnonymousLogin");
    }

    /// <summary>
    /// Wrapper for the action SetConfigPassword.
    /// </summary>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    public void SetConfigPassword(string newPassword)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPassword", newPassword);
      this.SendRequest("SetConfigPassword", arguments);
    }
  }
}
