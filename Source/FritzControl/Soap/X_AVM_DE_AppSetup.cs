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
  public class X_AVM_DE_AppSetup
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
    /// Wrapper for the action GetConfig.
    /// </summary>
    /// <returns>The result (GetConfigResult) of the action.</returns>
    public GetConfigResult GetConfig()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action GetAppMessageFilter.
    /// </summary>
    /// <param name="newAppId">The SOAP parameter NewAppId.</param>
    /// <returns>The result (NewFilterList) of the action.</returns>
    public string GetAppMessageFilter(string newAppId)
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action RegisterApp.
    /// </summary>
    /// <param name="newAppId">The SOAP parameter NewAppId.</param>
    /// <param name="newAppDisplayName">The SOAP parameter NewAppDisplayName.</param>
    /// <param name="newAppDeviceMAC">The SOAP parameter NewAppDeviceMAC.</param>
    /// <param name="newAppUsername">The SOAP parameter NewAppUsername.</param>
    /// <param name="newAppPassword">The SOAP parameter NewAppPassword.</param>
    /// <param name="newAppRight">The SOAP parameter NewAppRight.</param>
    /// <param name="newNasRight">The SOAP parameter NewNasRight.</param>
    /// <param name="newPhoneRight">The SOAP parameter NewPhoneRight.</param>
    /// <param name="newHomeautoRight">The SOAP parameter NewHomeautoRight.</param>
    /// <param name="newAppInternetRights">The SOAP parameter NewAppInternetRights.</param>
    public void RegisterApp(string newAppId, string newAppDisplayName, string newAppDeviceMAC, string newAppUsername, string newAppPassword, string newAppRight, string newNasRight, string newPhoneRight, string newHomeautoRight, bool newAppInternetRights)
    {
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
    }

    /// <summary>
    /// Wrapper for the action SetAppMessageFilter.
    /// </summary>
    /// <param name="newAppId">The SOAP parameter NewAppId.</param>
    /// <param name="newType">The SOAP parameter NewType.</param>
    /// <param name="newFilter">The SOAP parameter NewFilter.</param>
    public void SetAppMessageFilter(string newAppId, string newType, string newFilter)
    {
    }

    /// <summary>
    /// Wrapper for the action SetAppMessageReceiver.
    /// </summary>
    /// <param name="newAppId">The SOAP parameter NewAppId.</param>
    /// <param name="newCryptAlgos">The SOAP parameter NewCryptAlgos.</param>
    /// <param name="newAppAVMAddress">The SOAP parameter NewAppAVMAddress.</param>
    /// <param name="newAppAVMPasswordHash">The SOAP parameter NewAppAVMPasswordHash.</param>
    /// <returns>The result (SetAppMessageReceiverResult) of the action.</returns>
    public SetAppMessageReceiverResult SetAppMessageReceiver(string newAppId, string newCryptAlgos, string newAppAVMAddress, string newAppAVMPasswordHash)
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action ResetEvent.
    /// </summary>
    /// <param name="newEventId">The SOAP parameter NewEventId.</param>
    public void ResetEvent(uint newEventId)
    {
    }
  }
}
