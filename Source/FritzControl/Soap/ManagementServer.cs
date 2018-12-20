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
    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (GetInfoResult) of the action.</returns>
    public GetInfoResult GetInfo()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action SetManagementServerURL.
    /// </summary>
    /// <param name="newURL">The SOAP parameter NewURL.</param>
    public void SetManagementServerURL(string newURL)
    {
    }

    /// <summary>
    /// Wrapper for the action SetManagementServerUsername.
    /// </summary>
    /// <param name="newUsername">The SOAP parameter NewUsername.</param>
    public void SetManagementServerUsername(string newUsername)
    {
    }

    /// <summary>
    /// Wrapper for the action SetManagementServerPassword.
    /// </summary>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    public void SetManagementServerPassword(string newPassword)
    {
    }

    /// <summary>
    /// Wrapper for the action SetPeriodicInform.
    /// </summary>
    /// <param name="newPeriodicInformEnable">The SOAP parameter NewPeriodicInformEnable.</param>
    /// <param name="newPeriodicInformInterval">The SOAP parameter NewPeriodicInformInterval.</param>
    /// <param name="newPeriodicInformTime">The SOAP parameter NewPeriodicInformTime.</param>
    public void SetPeriodicInform(bool newPeriodicInformEnable, uint newPeriodicInformInterval, System.DateTime newPeriodicInformTime)
    {
    }

    /// <summary>
    /// Wrapper for the action SetConnectionRequestAuthentication.
    /// </summary>
    /// <param name="newConnectionRequestUsername">The SOAP parameter NewConnectionRequestUsername.</param>
    /// <param name="newConnectionRequestPassword">The SOAP parameter NewConnectionRequestPassword.</param>
    public void SetConnectionRequestAuthentication(string newConnectionRequestUsername, string newConnectionRequestPassword)
    {
    }

    /// <summary>
    /// Wrapper for the action SetUpgradeManagement.
    /// </summary>
    /// <param name="newUpgradesManaged">The SOAP parameter NewUpgradesManaged.</param>
    public void SetUpgradeManagement(bool newUpgradesManaged)
    {
    }

    /// <summary>
    /// Wrapper for the action X_SetTR069Enable.
    /// </summary>
    /// <param name="newTR069Enabled">The SOAP parameter NewTR069Enabled.</param>
    public void X_SetTR069Enable(bool newTR069Enabled)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetTR069FirmwareDownloadEnabled.
    /// </summary>
    /// <returns>The result (NewTR069FirmwareDownloadEnabled) of the action.</returns>
    public bool X_AVM_DE_GetTR069FirmwareDownloadEnabled()
    {
      return false;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetTR069FirmwareDownloadEnabled.
    /// </summary>
    /// <param name="newTR069FirmwareDownloadEnabled">The SOAP parameter NewTR069FirmwareDownloadEnabled.</param>
    public void X_AVM_DE_SetTR069FirmwareDownloadEnabled(bool newTR069FirmwareDownloadEnabled)
    {
    }
  }
}
