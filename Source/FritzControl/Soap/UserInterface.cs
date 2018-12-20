// <copyright file="UserInterface.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:UserInterface:1.
  /// </summary>
  public class UserInterface : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:UserInterface:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (GetInfoResult) of the action.</returns>
    public GetInfoResult GetInfo()
    {
      return this.SendRequest<GetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_CheckUpdate.
    /// </summary>
    /// <param name="newX_AVM_DE_LaborVersion">The SOAP parameter NewX_AVM-DE_LaborVersion.</param>
    public void X_AVM_DE_CheckUpdate(string newX_AVM_DE_LaborVersion)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewX_AVM-DE_LaborVersion", newX_AVM_DE_LaborVersion);
      this.SendRequest("X_AVM-DE_CheckUpdate", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_DoUpdate.
    /// </summary>
    /// <returns>The result (X_AVM_DE_DoUpdateResult) of the action.</returns>
    public X_AVM_DE_DoUpdateResult X_AVM_DE_DoUpdate()
    {
      return this.SendRequest<X_AVM_DE_DoUpdateResult>("X_AVM-DE_DoUpdate");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_DoPrepareCGI.
    /// </summary>
    /// <returns>The result (X_AVM_DE_DoPrepareCGIResult) of the action.</returns>
    public X_AVM_DE_DoPrepareCGIResult X_AVM_DE_DoPrepareCGI()
    {
      return this.SendRequest<X_AVM_DE_DoPrepareCGIResult>("X_AVM-DE_DoPrepareCGI");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_DoManualUpdate.
    /// </summary>
    /// <param name="newX_AVM_DE_AllowDowngrade">The SOAP parameter NewX_AVM-DE_AllowDowngrade.</param>
    /// <param name="newX_AVM_DE_DownloadURL">The SOAP parameter NewX_AVM-DE_DownloadURL.</param>
    public void X_AVM_DE_DoManualUpdate(bool newX_AVM_DE_AllowDowngrade, string newX_AVM_DE_DownloadURL)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewX_AVM-DE_AllowDowngrade", newX_AVM_DE_AllowDowngrade);
      arguments.Add("NewX_AVM-DE_DownloadURL", newX_AVM_DE_DownloadURL);
      this.SendRequest("X_AVM-DE_DoManualUpdate", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetInternationalConfig.
    /// </summary>
    /// <returns>The result (X_AVM_DE_GetInternationalConfigResult) of the action.</returns>
    public X_AVM_DE_GetInternationalConfigResult X_AVM_DE_GetInternationalConfig()
    {
      return this.SendRequest<X_AVM_DE_GetInternationalConfigResult>("X_AVM-DE_GetInternationalConfig");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetInternationalConfig.
    /// </summary>
    /// <param name="newX_AVM_DE_Language">The SOAP parameter NewX_AVM-DE_Language.</param>
    /// <param name="newX_AVM_DE_Country">The SOAP parameter NewX_AVM-DE_Country.</param>
    /// <param name="newX_AVM_DE_Annex">The SOAP parameter NewX_AVM-DE_Annex.</param>
    public void X_AVM_DE_SetInternationalConfig(string newX_AVM_DE_Language, string newX_AVM_DE_Country, string newX_AVM_DE_Annex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewX_AVM-DE_Language", newX_AVM_DE_Language);
      arguments.Add("NewX_AVM-DE_Country", newX_AVM_DE_Country);
      arguments.Add("NewX_AVM-DE_Annex", newX_AVM_DE_Annex);
      this.SendRequest("X_AVM-DE_SetInternationalConfig", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetInfo.
    /// </summary>
    /// <returns>The result (X_AVM_DE_GetInfoResult) of the action.</returns>
    public X_AVM_DE_GetInfoResult X_AVM_DE_GetInfo()
    {
      return this.SendRequest<X_AVM_DE_GetInfoResult>("X_AVM-DE_GetInfo");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetConfig.
    /// </summary>
    /// <param name="newX_AVM_DE_AutoUpdateMode">The SOAP parameter NewX_AVM-DE_AutoUpdateMode.</param>
    public void X_AVM_DE_SetConfig(string newX_AVM_DE_AutoUpdateMode)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewX_AVM-DE_AutoUpdateMode", newX_AVM_DE_AutoUpdateMode);
      this.SendRequest("X_AVM-DE_SetConfig", arguments);
    }
  }
}
