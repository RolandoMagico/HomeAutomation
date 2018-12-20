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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_OnTel:1
  /// </summary>
  public class X_AVM_DE_OnTel
  {
    /// <summary>
    /// Wrapper for the action GetInfo
    /// </summary>
    public void GetInfo()
    {
    }

    /// <summary>
    /// Wrapper for the action SetEnable
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetEnable(bool newEnable)
    {
    }

    /// <summary>
    /// Wrapper for the action SetConfig
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    /// <param name="newUrl">The SOAP parameter NewUrl.</param>
    /// <param name="newServiceId">The SOAP parameter NewServiceId.</param>
    /// <param name="newUsername">The SOAP parameter NewUsername.</param>
    /// <param name="newPassword">The SOAP parameter NewPassword.</param>
    /// <param name="newName">The SOAP parameter NewName.</param>
    public void SetConfig(bool newEnable, string newUrl, string newServiceId, string newUsername, string newPassword, string newName)
    {
    }

    /// <summary>
    /// Wrapper for the action GetInfoByIndex
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    public void GetInfoByIndex(ushort newIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action SetEnableByIndex
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetEnableByIndex(ushort newIndex, bool newEnable)
    {
    }

    /// <summary>
    /// Wrapper for the action SetConfigByIndex
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
    }

    /// <summary>
    /// Wrapper for the action DeleteByIndex
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    public void DeleteByIndex(ushort newIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action GetNumberOfEntries
    /// </summary>
    public void GetNumberOfEntries()
    {
    }

    /// <summary>
    /// Wrapper for the action GetCallList
    /// </summary>
    public void GetCallList()
    {
    }

    /// <summary>
    /// Wrapper for the action GetPhonebookList
    /// </summary>
    public void GetPhonebookList()
    {
    }

    /// <summary>
    /// Wrapper for the action GetPhonebook
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    public void GetPhonebook(ushort newPhonebookID)
    {
    }

    /// <summary>
    /// Wrapper for the action AddPhonebook
    /// </summary>
    /// <param name="newPhonebookExtraID">The SOAP parameter NewPhonebookExtraID.</param>
    /// <param name="newPhonebookName">The SOAP parameter NewPhonebookName.</param>
    public void AddPhonebook(string newPhonebookExtraID, string newPhonebookName)
    {
    }

    /// <summary>
    /// Wrapper for the action DeletePhonebook
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookExtraID">The SOAP parameter NewPhonebookExtraID.</param>
    public void DeletePhonebook(ushort newPhonebookID, string newPhonebookExtraID)
    {
    }

    /// <summary>
    /// Wrapper for the action GetPhonebookEntry
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryID">The SOAP parameter NewPhonebookEntryID.</param>
    public void GetPhonebookEntry(ushort newPhonebookID, uint newPhonebookEntryID)
    {
    }

    /// <summary>
    /// Wrapper for the action GetPhonebookEntryUID
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryUniqueID">The SOAP parameter NewPhonebookEntryUniqueID.</param>
    public void GetPhonebookEntryUID(ushort newPhonebookID, uint newPhonebookEntryUniqueID)
    {
    }

    /// <summary>
    /// Wrapper for the action SetPhonebookEntry
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryID">The SOAP parameter NewPhonebookEntryID.</param>
    /// <param name="newPhonebookEntryData">The SOAP parameter NewPhonebookEntryData.</param>
    public void SetPhonebookEntry(ushort newPhonebookID, uint newPhonebookEntryID, string newPhonebookEntryData)
    {
    }

    /// <summary>
    /// Wrapper for the action SetPhonebookEntryUID
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryData">The SOAP parameter NewPhonebookEntryData.</param>
    public void SetPhonebookEntryUID(ushort newPhonebookID, string newPhonebookEntryData)
    {
    }

    /// <summary>
    /// Wrapper for the action DeletePhonebookEntry
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryID">The SOAP parameter NewPhonebookEntryID.</param>
    public void DeletePhonebookEntry(ushort newPhonebookID, uint newPhonebookEntryID)
    {
    }

    /// <summary>
    /// Wrapper for the action DeletePhonebookEntryUID
    /// </summary>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    /// <param name="newPhonebookEntryUniqueID">The SOAP parameter NewPhonebookEntryUniqueID.</param>
    public void DeletePhonebookEntryUID(ushort newPhonebookID, uint newPhonebookEntryUniqueID)
    {
    }

    /// <summary>
    /// Wrapper for the action GetDECTHandsetList
    /// </summary>
    public void GetDECTHandsetList()
    {
    }

    /// <summary>
    /// Wrapper for the action GetDECTHandsetInfo
    /// </summary>
    /// <param name="newDectID">The SOAP parameter NewDectID.</param>
    public void GetDECTHandsetInfo(ushort newDectID)
    {
    }

    /// <summary>
    /// Wrapper for the action SetDECTHandsetPhonebook
    /// </summary>
    /// <param name="newDectID">The SOAP parameter NewDectID.</param>
    /// <param name="newPhonebookID">The SOAP parameter NewPhonebookID.</param>
    public void SetDECTHandsetPhonebook(ushort newDectID, ushort newPhonebookID)
    {
    }

    /// <summary>
    /// Wrapper for the action GetNumberOfDeflections
    /// </summary>
    public void GetNumberOfDeflections()
    {
    }

    /// <summary>
    /// Wrapper for the action GetDeflection
    /// </summary>
    /// <param name="newDeflectionId">The SOAP parameter NewDeflectionId.</param>
    public void GetDeflection(ushort newDeflectionId)
    {
    }

    /// <summary>
    /// Wrapper for the action GetDeflections
    /// </summary>
    public void GetDeflections()
    {
    }

    /// <summary>
    /// Wrapper for the action SetDeflectionEnable
    /// </summary>
    /// <param name="newDeflectionId">The SOAP parameter NewDeflectionId.</param>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetDeflectionEnable(ushort newDeflectionId, bool newEnable)
    {
    }
  }
}
