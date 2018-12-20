// <copyright file="X_AVM_DE_OnTel.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_OnTel:1.
  /// </summary>
  public class X_AVM_DE_OnTel : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:X_AVM-DE_OnTel:1";

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (X_AVM_DE_OnTelGetInfoResult) of the action.</returns>
    public X_AVM_DE_OnTelGetInfoResult GetInfo()
    {
      return this.SendRequest<X_AVM_DE_OnTelGetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action SetEnable.
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetEnable(bool newEnable)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewEnable", newEnable);
      this.SendRequest("SetEnable", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetConfig.
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    /// <param name="newUrl">The SOAP parameter NewUrl.</param>
    /// <param name="newServiceId">The SOAP parameter NewServiceId.</param>
    /// <param name="newUsername">The SOAP parameter NewUsername.</param>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    /// <param name="newName">The SOAP parameter NewName.</param>
    public void SetConfig(bool newEnable, string newUrl, string newServiceId, string newUsername, string newPassword, string newName)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewEnable", newEnable);
      arguments.Add("NewUrl", newUrl);
      arguments.Add("NewServiceId", newServiceId);
      arguments.Add("NewUsername", newUsername);
      arguments.Add("NewPassword", newPassword);
      arguments.Add("NewName", newName);
      this.SendRequest("SetConfig", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetInfoByIndex.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <returns>The result (X_AVM_DE_OnTelGetInfoByIndexResult) of the action.</returns>
    public X_AVM_DE_OnTelGetInfoByIndexResult GetInfoByIndex(ushort newIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      return this.SendRequest<X_AVM_DE_OnTelGetInfoByIndexResult>("GetInfoByIndex", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetEnableByIndex.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetEnableByIndex(ushort newIndex, bool newEnable)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      arguments.Add("NewEnable", newEnable);
      this.SendRequest("SetEnableByIndex", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetConfigByIndex.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    /// <param name="newUrl">The SOAP parameter NewUrl.</param>
    /// <param name="newServiceId">The SOAP parameter NewServiceId.</param>
    /// <param name="newUsername">The SOAP parameter NewUsername.</param>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    /// <param name="newName">The SOAP parameter NewName.</param>
    public void SetConfigByIndex(ushort newIndex, bool newEnable, string newUrl, string newServiceId, string newUsername, string newPassword, string newName)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      arguments.Add("NewEnable", newEnable);
      arguments.Add("NewUrl", newUrl);
      arguments.Add("NewServiceId", newServiceId);
      arguments.Add("NewUsername", newUsername);
      arguments.Add("NewPassword", newPassword);
      arguments.Add("NewName", newName);
      this.SendRequest("SetConfigByIndex", arguments);
    }

    /// <summary>
    /// Wrapper for the action DeleteByIndex.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    public void DeleteByIndex(ushort newIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      this.SendRequest("DeleteByIndex", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetNumberOfEntries.
    /// </summary>
    /// <returns>The result (NewOnTelNumberOfEntries) of the action.</returns>
    public ushort GetNumberOfEntries()
    {
      return this.SendRequest<ushort>("GetNumberOfEntries");
    }

    /// <summary>
    /// Wrapper for the action GetCallList.
    /// </summary>
    /// <returns>The result (NewCallListURL) of the action.</returns>
    public string GetCallList()
    {
      return this.SendRequest<string>("GetCallList");
    }

    /// <summary>
    /// Wrapper for the action GetPhonebookList.
    /// </summary>
    /// <returns>The result (NewPhonebookList) of the action.</returns>
    public string GetPhonebookList()
    {
      return this.SendRequest<string>("GetPhonebookList");
    }

    /// <summary>
    /// Wrapper for the action GetPhonebook.
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <returns>The result (X_AVM_DE_OnTelGetPhonebookResult) of the action.</returns>
    public X_AVM_DE_OnTelGetPhonebookResult GetPhonebook(ushort newPhonebookID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPhonebookID", newPhonebookID);
      return this.SendRequest<X_AVM_DE_OnTelGetPhonebookResult>("GetPhonebook", arguments);
    }

    /// <summary>
    /// Wrapper for the action AddPhonebook.
    /// </summary>
    /// <param name="newPhonebookExtraID">The SOAP parameter NewPhonebookExtraID.</param>
    /// <param name="newPhonebookName">The SOAP parameter NewPhonebookName.</param>
    public void AddPhonebook(string newPhonebookExtraID, string newPhonebookName)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPhonebookExtraID", newPhonebookExtraID);
      arguments.Add("NewPhonebookName", newPhonebookName);
      this.SendRequest("AddPhonebook", arguments);
    }

    /// <summary>
    /// Wrapper for the action DeletePhonebook.
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookExtraID">The SOAP parameter NewPhonebookExtraID.</param>
    public void DeletePhonebook(ushort newPhonebookID, string newPhonebookExtraID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPhonebookID", newPhonebookID);
      arguments.Add("NewPhonebookExtraID", newPhonebookExtraID);
      this.SendRequest("DeletePhonebook", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetPhonebookEntry.
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryID">The SOAP parameter NewPhonebookEntryID.</param>
    /// <returns>The result (NewPhonebookEntryData) of the action.</returns>
    public string GetPhonebookEntry(ushort newPhonebookID, uint newPhonebookEntryID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPhonebookID", newPhonebookID);
      arguments.Add("NewPhonebookEntryID", newPhonebookEntryID);
      return this.SendRequest<string>("GetPhonebookEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetPhonebookEntryUID.
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryUniqueID">The SOAP parameter NewPhonebookEntryUniqueID.</param>
    /// <returns>The result (NewPhonebookEntryData) of the action.</returns>
    public string GetPhonebookEntryUID(ushort newPhonebookID, uint newPhonebookEntryUniqueID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPhonebookID", newPhonebookID);
      arguments.Add("NewPhonebookEntryUniqueID", newPhonebookEntryUniqueID);
      return this.SendRequest<string>("GetPhonebookEntryUID", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetPhonebookEntry.
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryID">The SOAP parameter NewPhonebookEntryID.</param>
    /// <param name="newPhonebookEntryData">The SOAP parameter NewPhonebookEntryData.</param>
    public void SetPhonebookEntry(ushort newPhonebookID, uint newPhonebookEntryID, string newPhonebookEntryData)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPhonebookID", newPhonebookID);
      arguments.Add("NewPhonebookEntryID", newPhonebookEntryID);
      arguments.Add("NewPhonebookEntryData", newPhonebookEntryData);
      this.SendRequest("SetPhonebookEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetPhonebookEntryUID.
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryData">The SOAP parameter NewPhonebookEntryData.</param>
    /// <returns>The result (NewPhonebookEntryUniqueID) of the action.</returns>
    public uint SetPhonebookEntryUID(ushort newPhonebookID, string newPhonebookEntryData)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPhonebookID", newPhonebookID);
      arguments.Add("NewPhonebookEntryData", newPhonebookEntryData);
      return this.SendRequest<uint>("SetPhonebookEntryUID", arguments);
    }

    /// <summary>
    /// Wrapper for the action DeletePhonebookEntry.
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryID">The SOAP parameter NewPhonebookEntryID.</param>
    public void DeletePhonebookEntry(ushort newPhonebookID, uint newPhonebookEntryID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPhonebookID", newPhonebookID);
      arguments.Add("NewPhonebookEntryID", newPhonebookEntryID);
      this.SendRequest("DeletePhonebookEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action DeletePhonebookEntryUID.
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryUniqueID">The SOAP parameter NewPhonebookEntryUniqueID.</param>
    public void DeletePhonebookEntryUID(ushort newPhonebookID, uint newPhonebookEntryUniqueID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPhonebookID", newPhonebookID);
      arguments.Add("NewPhonebookEntryUniqueID", newPhonebookEntryUniqueID);
      this.SendRequest("DeletePhonebookEntryUID", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetDECTHandsetList.
    /// </summary>
    /// <returns>The result (NewDectIDList) of the action.</returns>
    public string GetDECTHandsetList()
    {
      return this.SendRequest<string>("GetDECTHandsetList");
    }

    /// <summary>
    /// Wrapper for the action GetDECTHandsetInfo.
    /// </summary>
    /// <param name="newDectID">The SOAP parameter NewDectID.</param>
    /// <returns>The result (X_AVM_DE_OnTelGetDECTHandsetInfoResult) of the action.</returns>
    public X_AVM_DE_OnTelGetDECTHandsetInfoResult GetDECTHandsetInfo(ushort newDectID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDectID", newDectID);
      return this.SendRequest<X_AVM_DE_OnTelGetDECTHandsetInfoResult>("GetDECTHandsetInfo", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetDECTHandsetPhonebook.
    /// </summary>
    /// <param name="newDectID">The SOAP parameter NewDectID.</param>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    public void SetDECTHandsetPhonebook(ushort newDectID, ushort newPhonebookID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDectID", newDectID);
      arguments.Add("NewPhonebookID", newPhonebookID);
      this.SendRequest("SetDECTHandsetPhonebook", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetNumberOfDeflections.
    /// </summary>
    /// <returns>The result (NewNumberOfDeflections) of the action.</returns>
    public ushort GetNumberOfDeflections()
    {
      return this.SendRequest<ushort>("GetNumberOfDeflections");
    }

    /// <summary>
    /// Wrapper for the action GetDeflection.
    /// </summary>
    /// <param name="newDeflectionId">The SOAP parameter NewDeflectionId.</param>
    /// <returns>The result (X_AVM_DE_OnTelGetDeflectionResult) of the action.</returns>
    public X_AVM_DE_OnTelGetDeflectionResult GetDeflection(ushort newDeflectionId)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDeflectionId", newDeflectionId);
      return this.SendRequest<X_AVM_DE_OnTelGetDeflectionResult>("GetDeflection", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetDeflections.
    /// </summary>
    /// <returns>The result (NewDeflectionList) of the action.</returns>
    public string GetDeflections()
    {
      return this.SendRequest<string>("GetDeflections");
    }

    /// <summary>
    /// Wrapper for the action SetDeflectionEnable.
    /// </summary>
    /// <param name="newDeflectionId">The SOAP parameter NewDeflectionId.</param>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetDeflectionEnable(ushort newDeflectionId, bool newEnable)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDeflectionId", newDeflectionId);
      arguments.Add("NewEnable", newEnable);
      this.SendRequest("SetDeflectionEnable", arguments);
    }
  }
}
