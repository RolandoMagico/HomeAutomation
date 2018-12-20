// <copyright file="ManagementServer.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:ManagementServer:1.
  /// </summary>
  public class ManagementServer : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:ManagementServer:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (GetInfoResult) of the action.</returns>
    public GetInfoResult GetInfo()
    {
      return this.SendRequest<GetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action SetManagementServerURL.
    /// </summary>
    /// <param name="newURL">The SOAP parameter NewURL.</param>
    public void SetManagementServerURL(string newURL)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewURL", newURL);
      this.SendRequest("SetManagementServerURL", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetManagementServerUsername.
    /// </summary>
    /// <param name="newUsername">The SOAP parameter NewUsername.</param>
    public void SetManagementServerUsername(string newUsername)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewUsername", newUsername);
      this.SendRequest("SetManagementServerUsername", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetManagementServerPassword.
    /// </summary>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    public void SetManagementServerPassword(string newPassword)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPassword", newPassword);
      this.SendRequest("SetManagementServerPassword", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetPeriodicInform.
    /// </summary>
    /// <param name="newPeriodicInformEnable">The SOAP parameter NewPeriodicInformEnable.</param>
    /// <param name="newPeriodicInformInterval">The SOAP parameter NewPeriodicInformInterval.</param>
    /// <param name="newPeriodicInformTime">The SOAP parameter NewPeriodicInformTime.</param>
    public void SetPeriodicInform(bool newPeriodicInformEnable, uint newPeriodicInformInterval, System.DateTime newPeriodicInformTime)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPeriodicInformEnable", newPeriodicInformEnable);
      arguments.Add("NewPeriodicInformInterval", newPeriodicInformInterval);
      arguments.Add("NewPeriodicInformTime", newPeriodicInformTime);
      this.SendRequest("SetPeriodicInform", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetConnectionRequestAuthentication.
    /// </summary>
    /// <param name="newConnectionRequestUsername">The SOAP parameter NewConnectionRequestUsername.</param>
    /// <param name="newConnectionRequestPassword">The SOAP parameter NewConnectionRequestPassword.</param>
    public void SetConnectionRequestAuthentication(string newConnectionRequestUsername, string newConnectionRequestPassword)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewConnectionRequestUsername", newConnectionRequestUsername);
      arguments.Add("NewConnectionRequestPassword", newConnectionRequestPassword);
      this.SendRequest("SetConnectionRequestAuthentication", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetUpgradeManagement.
    /// </summary>
    /// <param name="newUpgradesManaged">The SOAP parameter NewUpgradesManaged.</param>
    public void SetUpgradeManagement(bool newUpgradesManaged)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewUpgradesManaged", newUpgradesManaged);
      this.SendRequest("SetUpgradeManagement", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_SetTR069Enable.
    /// </summary>
    /// <param name="newTR069Enabled">The SOAP parameter NewTR069Enabled.</param>
    public void X_SetTR069Enable(bool newTR069Enabled)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewTR069Enabled", newTR069Enabled);
      this.SendRequest("X_SetTR069Enable", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetTR069FirmwareDownloadEnabled.
    /// </summary>
    /// <returns>The result (NewTR069FirmwareDownloadEnabled) of the action.</returns>
    public bool X_AVM_DE_GetTR069FirmwareDownloadEnabled()
    {
      return this.SendRequest<bool>("X_AVM-DE_GetTR069FirmwareDownloadEnabled");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetTR069FirmwareDownloadEnabled.
    /// </summary>
    /// <param name="newTR069FirmwareDownloadEnabled">The SOAP parameter NewTR069FirmwareDownloadEnabled.</param>
    public void X_AVM_DE_SetTR069FirmwareDownloadEnabled(bool newTR069FirmwareDownloadEnabled)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewTR069FirmwareDownloadEnabled", newTR069FirmwareDownloadEnabled);
      this.SendRequest("X_AVM-DE_SetTR069FirmwareDownloadEnabled", arguments);
    }
  }
}
