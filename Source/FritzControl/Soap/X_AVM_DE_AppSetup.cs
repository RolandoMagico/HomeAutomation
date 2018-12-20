// <copyright file="X_AVM_DE_AppSetup.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_AppSetup:1.
  /// </summary>
  public class X_AVM_DE_AppSetup : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:X_AVM-DE_AppSetup:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (X_AVM_DE_AppSetupGetInfoResult) of the action.</returns>
    public X_AVM_DE_AppSetupGetInfoResult GetInfo()
    {
      return this.SendRequest<X_AVM_DE_AppSetupGetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action GetConfig.
    /// </summary>
    /// <returns>The result (X_AVM_DE_AppSetupGetConfigResult) of the action.</returns>
    public X_AVM_DE_AppSetupGetConfigResult GetConfig()
    {
      return this.SendRequest<X_AVM_DE_AppSetupGetConfigResult>("GetConfig");
    }

    /// <summary>
    /// Wrapper for the action GetAppMessageFilter.
    /// </summary>
    /// <param name="newAppId">The SOAP parameter NewAppId.</param>
    /// <returns>The result (NewFilterList) of the action.</returns>
    public string GetAppMessageFilter(string newAppId)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAppId", newAppId);
      return this.SendRequest<string>("GetAppMessageFilter", arguments);
    }

    /// <summary>
    /// Wrapper for the action RegisterApp.
    /// </summary>
    /// <param name="newAppId">The SOAP parameter NewAppId.</param>
    /// <param name="newAppDisplayName">The SOAP parameter NewAppDisplayName.</param>
    /// <param name="newAppDeviceMAC">The SOAP parameter NewAppDeviceMAC.</param>
    /// <param name="newAppUsername">The SOAP parameter NewAppUsername.</param>
    /// <param name="newAppPassword">The SOAP parameter NewAppPassword.</param>
    /// <param name="newAppRight">The SOAP parameter NewAppRight. Allowed values: NO, RO, RW, UNDEFINED.</param>
    /// <param name="newNasRight">The SOAP parameter NewNasRight. Allowed values: NO, RO, RW, UNDEFINED.</param>
    /// <param name="newPhoneRight">The SOAP parameter NewPhoneRight. Allowed values: NO, RO, RW, UNDEFINED.</param>
    /// <param name="newHomeautoRight">The SOAP parameter NewHomeautoRight. Allowed values: NO, RO, RW, UNDEFINED.</param>
    /// <param name="newAppInternetRights">The SOAP parameter NewAppInternetRights.</param>
    public void RegisterApp(string newAppId, string newAppDisplayName, string newAppDeviceMAC, string newAppUsername, string newAppPassword, string newAppRight, string newNasRight, string newPhoneRight, string newHomeautoRight, bool newAppInternetRights)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAppId", newAppId);
      arguments.Add("NewAppDisplayName", newAppDisplayName);
      arguments.Add("NewAppDeviceMAC", newAppDeviceMAC);
      arguments.Add("NewAppUsername", newAppUsername);
      arguments.Add("NewAppPassword", newAppPassword);
      arguments.Add("NewAppRight", newAppRight);
      arguments.Add("NewNasRight", newNasRight);
      arguments.Add("NewPhoneRight", newPhoneRight);
      arguments.Add("NewHomeautoRight", newHomeautoRight);
      arguments.Add("NewAppInternetRights", newAppInternetRights);
      this.SendRequest("RegisterApp", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetAppVPN.
    /// </summary>
    /// <param name="newAppId">The SOAP parameter NewAppId.</param>
    /// <param name="newIPSecIdentifier">The SOAP parameter NewIPSecIdentifier.</param>
    /// <param name="newIPSecPreSharedKey">The SOAP parameter NewIPSecPreSharedKey.</param>
    /// <param name="newIPSecXauthUsername">The SOAP parameter NewIPSecXauthUsername.</param>
    /// <param name="newIPSecXauthPassword">The SOAP parameter NewIPSecXauthPassword.</param>
    public void SetAppVPN(string newAppId, string newIPSecIdentifier, string newIPSecPreSharedKey, string newIPSecXauthUsername, string newIPSecXauthPassword)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAppId", newAppId);
      arguments.Add("NewIPSecIdentifier", newIPSecIdentifier);
      arguments.Add("NewIPSecPreSharedKey", newIPSecPreSharedKey);
      arguments.Add("NewIPSecXauthUsername", newIPSecXauthUsername);
      arguments.Add("NewIPSecXauthPassword", newIPSecXauthPassword);
      this.SendRequest("SetAppVPN", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetAppVPNwithPFS.
    /// </summary>
    /// <param name="newAppId">The SOAP parameter NewAppId.</param>
    /// <param name="newIPSecIdentifier">The SOAP parameter NewIPSecIdentifier.</param>
    /// <param name="newIPSecPreSharedKey">The SOAP parameter NewIPSecPreSharedKey.</param>
    /// <param name="newIPSecXauthUsername">The SOAP parameter NewIPSecXauthUsername.</param>
    /// <param name="newIPSecXauthPassword">The SOAP parameter NewIPSecXauthPassword.</param>
    public void SetAppVPNwithPFS(string newAppId, string newIPSecIdentifier, string newIPSecPreSharedKey, string newIPSecXauthUsername, string newIPSecXauthPassword)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAppId", newAppId);
      arguments.Add("NewIPSecIdentifier", newIPSecIdentifier);
      arguments.Add("NewIPSecPreSharedKey", newIPSecPreSharedKey);
      arguments.Add("NewIPSecXauthUsername", newIPSecXauthUsername);
      arguments.Add("NewIPSecXauthPassword", newIPSecXauthPassword);
      this.SendRequest("SetAppVPNwithPFS", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetAppMessageFilter.
    /// </summary>
    /// <param name="newAppId">The SOAP parameter NewAppId.</param>
    /// <param name="newType">The SOAP parameter NewType. Allowed values: aha_ident, tel_local_number.</param>
    /// <param name="newFilter">The SOAP parameter NewFilter.</param>
    public void SetAppMessageFilter(string newAppId, string newType, string newFilter)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAppId", newAppId);
      arguments.Add("NewType", newType);
      arguments.Add("NewFilter", newFilter);
      this.SendRequest("SetAppMessageFilter", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetAppMessageReceiver.
    /// </summary>
    /// <param name="newAppId">The SOAP parameter NewAppId.</param>
    /// <param name="newCryptAlgos">The SOAP parameter NewCryptAlgos.</param>
    /// <param name="newAppAVMAddress">The SOAP parameter NewAppAVMAddress.</param>
    /// <param name="newAppAVMPasswordHash">The SOAP parameter NewAppAVMPasswordHash.</param>
    /// <returns>The result (X_AVM_DE_AppSetupSetAppMessageReceiverResult) of the action.</returns>
    public X_AVM_DE_AppSetupSetAppMessageReceiverResult SetAppMessageReceiver(string newAppId, string newCryptAlgos, string newAppAVMAddress, string newAppAVMPasswordHash)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAppId", newAppId);
      arguments.Add("NewCryptAlgos", newCryptAlgos);
      arguments.Add("NewAppAVMAddress", newAppAVMAddress);
      arguments.Add("NewAppAVMPasswordHash", newAppAVMPasswordHash);
      return this.SendRequest<X_AVM_DE_AppSetupSetAppMessageReceiverResult>("SetAppMessageReceiver", arguments);
    }

    /// <summary>
    /// Wrapper for the action ResetEvent.
    /// </summary>
    /// <param name="newEventId">The SOAP parameter NewEventId.</param>
    public void ResetEvent(uint newEventId)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewEventId", newEventId);
      this.SendRequest("ResetEvent", arguments);
    }
  }
}
