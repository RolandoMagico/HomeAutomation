// <copyright file="DeviceConfig.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:DeviceConfig:1.
  /// </summary>
  public class DeviceConfig : BaseService
  {
    /// <summary>
    /// Wrapper for the action GetPersistentData.
    /// </summary>
    /// <returns>The result (NewPersistentData) of the action.</returns>
    public string GetPersistentData()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action SetPersistentData.
    /// </summary>
    /// <param name="newPersistentData">The SOAP parameter NewPersistentData.</param>
    public void SetPersistentData(string newPersistentData)
    {
    }

    /// <summary>
    /// Wrapper for the action ConfigurationStarted.
    /// </summary>
    /// <param name="newSessionID">The SOAP parameter NewSessionID.</param>
    public void ConfigurationStarted(string newSessionID)
    {
    }

    /// <summary>
    /// Wrapper for the action ConfigurationFinished.
    /// </summary>
    /// <returns>The result (NewStatus) of the action.</returns>
    public string ConfigurationFinished()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action FactoryReset.
    /// </summary>
    public void FactoryReset()
    {
    }

    /// <summary>
    /// Wrapper for the action Reboot.
    /// </summary>
    public void Reboot()
    {
    }

    /// <summary>
    /// Wrapper for the action X_GenerateUUID.
    /// </summary>
    /// <returns>The result (NewUUID) of the action.</returns>
    public System.Guid X_GenerateUUID()
    {
      return System.Guid.Empty;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetConfigFile.
    /// </summary>
    /// <param name="newX_AVM_DE_Password">The SOAP parameter NewX_AVM-DE_Password.</param>
    /// <returns>The result (NewX_AVM-DE_ConfigFileUrl) of the action.</returns>
    public string X_AVM_DE_GetConfigFile(string newX_AVM_DE_Password)
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetConfigFile.
    /// </summary>
    /// <param name="newX_AVM_DE_Password">The SOAP parameter NewX_AVM-DE_Password.</param>
    /// <param name="newX_AVM_DE_ConfigFileUrl">The SOAP parameter NewX_AVM-DE_ConfigFileUrl.</param>
    public void X_AVM_DE_SetConfigFile(string newX_AVM_DE_Password, string newX_AVM_DE_ConfigFileUrl)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_CreateUrlSID.
    /// </summary>
    /// <returns>The result (NewX_AVM-DE_UrlSID) of the action.</returns>
    public string X_AVM_DE_CreateUrlSID()
    {
      return null;
    }
  }
}
