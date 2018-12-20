// <copyright file="X_VoIP.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_VoIP:1.
  /// </summary>
  public class X_VoIP : BaseService
  {
    /// <summary>
    /// Wrapper for the action GetInfoEx.
    /// </summary>
    /// <returns>The result (GetInfoExResult) of the action.</returns>
    public GetInfoExResult GetInfoEx()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_AddVoIPAccount.
    /// </summary>
    /// <param name="newVoIPAccountIndex">The SOAP parameter NewVoIPAccountIndex.</param>
    /// <param name="newVoIPRegistrar">The SOAP parameter NewVoIPRegistrar.</param>
    /// <param name="newVoIPNumber">The SOAP parameter NewVoIPNumber.</param>
    /// <param name="newVoIPUsername">The SOAP parameter NewVoIPUsername.</param>
    /// <param name="newVoIPPassword">The SOAP parameter NewVoIPPassword.</param>
    /// <param name="newVoIPOutboundProxy">The SOAP parameter NewVoIPOutboundProxy.</param>
    /// <param name="newVoIPSTUNServer">The SOAP parameter NewVoIPSTUNServer.</param>
    public void X_AVM_DE_AddVoIPAccount(ushort newVoIPAccountIndex, string newVoIPRegistrar, string newVoIPNumber, string newVoIPUsername, string newVoIPPassword, string newVoIPOutboundProxy, string newVoIPSTUNServer)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetVoIPAccount.
    /// </summary>
    /// <param name="newVoIPAccountIndex">The SOAP parameter NewVoIPAccountIndex.</param>
    /// <returns>The result (X_AVM_DE_GetVoIPAccountResult) of the action.</returns>
    public X_AVM_DE_GetVoIPAccountResult X_AVM_DE_GetVoIPAccount(ushort newVoIPAccountIndex)
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_DelVoIPAccount.
    /// </summary>
    /// <param name="newVoIPAccountIndex">The SOAP parameter NewVoIPAccountIndex.</param>
    public void X_AVM_DE_DelVoIPAccount(ushort newVoIPAccountIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (GetInfoResult) of the action.</returns>
    public GetInfoResult GetInfo()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action SetConfig.
    /// </summary>
    /// <param name="newFaxT38Enable">The SOAP parameter NewFaxT38Enable.</param>
    /// <param name="newVoiceCoding">The SOAP parameter NewVoiceCoding.</param>
    public void SetConfig(bool newFaxT38Enable, string newVoiceCoding)
    {
    }

    /// <summary>
    /// Wrapper for the action GetMaxVoIPNumbers.
    /// </summary>
    /// <returns>The result (NewMaxVoIPNumbers) of the action.</returns>
    public ushort GetMaxVoIPNumbers()
    {
      return 0;
    }

    /// <summary>
    /// Wrapper for the action GetExistingVoIPNumbers.
    /// </summary>
    /// <returns>The result (NewExistingVoIPNumbers) of the action.</returns>
    public ushort GetExistingVoIPNumbers()
    {
      return 0;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetNumberOfClients.
    /// </summary>
    /// <returns>The result (NewX_AVM-DE_NumberOfClients) of the action.</returns>
    public ushort X_AVM_DE_GetNumberOfClients()
    {
      return 0;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetClient.
    /// </summary>
    /// <param name="newX_AVM_DE_ClientIndex">The SOAP parameter NewX_AVM-DE_ClientIndex.</param>
    /// <returns>The result (X_AVM_DE_GetClientResult) of the action.</returns>
    public X_AVM_DE_GetClientResult X_AVM_DE_GetClient(ushort newX_AVM_DE_ClientIndex)
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetClient2.
    /// </summary>
    /// <param name="newX_AVM_DE_ClientIndex">The SOAP parameter NewX_AVM-DE_ClientIndex.</param>
    /// <returns>The result (X_AVM_DE_GetClient2Result) of the action.</returns>
    public X_AVM_DE_GetClient2Result X_AVM_DE_GetClient2(ushort newX_AVM_DE_ClientIndex)
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetClient.
    /// </summary>
    /// <param name="newX_AVM_DE_ClientIndex">The SOAP parameter NewX_AVM-DE_ClientIndex.</param>
    /// <param name="newX_AVM_DE_ClientPassword">The SOAP parameter NewX_AVM-DE_ClientPassword.</param>
    /// <param name="newX_AVM_DE_PhoneName">The SOAP parameter NewX_AVM-DE_PhoneName.</param>
    /// <param name="newX_AVM_DE_OutGoingNumber">The SOAP parameter NewX_AVM-DE_OutGoingNumber.</param>
    public void X_AVM_DE_SetClient(ushort newX_AVM_DE_ClientIndex, string newX_AVM_DE_ClientPassword, string newX_AVM_DE_PhoneName, string newX_AVM_DE_OutGoingNumber)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetClient2.
    /// </summary>
    /// <param name="newX_AVM_DE_ClientIndex">The SOAP parameter NewX_AVM-DE_ClientIndex.</param>
    /// <param name="newX_AVM_DE_ClientPassword">The SOAP parameter NewX_AVM-DE_ClientPassword.</param>
    /// <param name="newX_AVM_DE_ClientId">The SOAP parameter NewX_AVM-DE_ClientId.</param>
    /// <param name="newX_AVM_DE_PhoneName">The SOAP parameter NewX_AVM-DE_PhoneName.</param>
    /// <param name="newX_AVM_DE_OutGoingNumber">The SOAP parameter NewX_AVM-DE_OutGoingNumber.</param>
    public void X_AVM_DE_SetClient2(ushort newX_AVM_DE_ClientIndex, string newX_AVM_DE_ClientPassword, string newX_AVM_DE_ClientId, string newX_AVM_DE_PhoneName, string newX_AVM_DE_OutGoingNumber)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetClient3.
    /// </summary>
    /// <param name="newX_AVM_DE_ClientIndex">The SOAP parameter NewX_AVM-DE_ClientIndex.</param>
    /// <returns>The result (X_AVM_DE_GetClient3Result) of the action.</returns>
    public X_AVM_DE_GetClient3Result X_AVM_DE_GetClient3(ushort newX_AVM_DE_ClientIndex)
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetClientByClientId.
    /// </summary>
    /// <param name="newX_AVM_DE_ClientId">The SOAP parameter NewX_AVM-DE_ClientId.</param>
    /// <returns>The result (X_AVM_DE_GetClientByClientIdResult) of the action.</returns>
    public X_AVM_DE_GetClientByClientIdResult X_AVM_DE_GetClientByClientId(string newX_AVM_DE_ClientId)
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetClient3.
    /// </summary>
    /// <param name="newX_AVM_DE_ClientIndex">The SOAP parameter NewX_AVM-DE_ClientIndex.</param>
    /// <param name="newX_AVM_DE_ClientPassword">The SOAP parameter NewX_AVM-DE_ClientPassword.</param>
    /// <param name="newX_AVM_DE_ClientId">The SOAP parameter NewX_AVM-DE_ClientId.</param>
    /// <param name="newX_AVM_DE_PhoneName">The SOAP parameter NewX_AVM-DE_PhoneName.</param>
    /// <param name="newX_AVM_DE_OutGoingNumber">The SOAP parameter NewX_AVM-DE_OutGoingNumber.</param>
    /// <param name="newX_AVM_DE_InComingNumbers">The SOAP parameter NewX_AVM-DE_InComingNumbers.</param>
    /// <param name="newX_AVM_DE_ExternalRegistration">The SOAP parameter NewX_AVM-DE_ExternalRegistration.</param>
    public void X_AVM_DE_SetClient3(ushort newX_AVM_DE_ClientIndex, string newX_AVM_DE_ClientPassword, string newX_AVM_DE_ClientId, string newX_AVM_DE_PhoneName, string newX_AVM_DE_OutGoingNumber, string newX_AVM_DE_InComingNumbers, bool newX_AVM_DE_ExternalRegistration)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetClient4.
    /// </summary>
    /// <param name="newX_AVM_DE_ClientIndex">The SOAP parameter NewX_AVM-DE_ClientIndex.</param>
    /// <param name="newX_AVM_DE_ClientPassword">The SOAP parameter NewX_AVM-DE_ClientPassword.</param>
    /// <param name="newX_AVM_DE_ClientUsername">The SOAP parameter NewX_AVM-DE_ClientUsername.</param>
    /// <param name="newX_AVM_DE_PhoneName">The SOAP parameter NewX_AVM-DE_PhoneName.</param>
    /// <param name="newX_AVM_DE_ClientId">The SOAP parameter NewX_AVM-DE_ClientId.</param>
    /// <param name="newX_AVM_DE_OutGoingNumber">The SOAP parameter NewX_AVM-DE_OutGoingNumber.</param>
    /// <param name="newX_AVM_DE_InComingNumbers">The SOAP parameter NewX_AVM-DE_InComingNumbers.</param>
    /// <returns>The result (NewX_AVM-DE_InternalNumber) of the action.</returns>
    public string X_AVM_DE_SetClient4(ushort newX_AVM_DE_ClientIndex, string newX_AVM_DE_ClientPassword, string newX_AVM_DE_ClientUsername, string newX_AVM_DE_PhoneName, string newX_AVM_DE_ClientId, string newX_AVM_DE_OutGoingNumber, string newX_AVM_DE_InComingNumbers)
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetClients.
    /// </summary>
    /// <returns>The result (NewX_AVM-DE_ClientList) of the action.</returns>
    public string X_AVM_DE_GetClients()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetNumberOfNumbers.
    /// </summary>
    /// <returns>The result (NewNumberOfNumbers) of the action.</returns>
    public uint X_AVM_DE_GetNumberOfNumbers()
    {
      return 0;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetNumbers.
    /// </summary>
    /// <returns>The result (NewNumberList) of the action.</returns>
    public string X_AVM_DE_GetNumbers()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_DeleteClient.
    /// </summary>
    /// <param name="newX_AVM_DE_ClientIndex">The SOAP parameter NewX_AVM-DE_ClientIndex.</param>
    public void X_AVM_DE_DeleteClient(ushort newX_AVM_DE_ClientIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_DialGetConfig.
    /// </summary>
    /// <returns>The result (NewX_AVM-DE_PhoneName) of the action.</returns>
    public string X_AVM_DE_DialGetConfig()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_DialSetConfig.
    /// </summary>
    /// <param name="newX_AVM_DE_PhoneName">The SOAP parameter NewX_AVM-DE_PhoneName.</param>
    public void X_AVM_DE_DialSetConfig(string newX_AVM_DE_PhoneName)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_DialNumber.
    /// </summary>
    /// <param name="newX_AVM_DE_PhoneNumber">The SOAP parameter NewX_AVM-DE_PhoneNumber.</param>
    public void X_AVM_DE_DialNumber(string newX_AVM_DE_PhoneNumber)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_DialHangup.
    /// </summary>
    public void X_AVM_DE_DialHangup()
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetPhonePort.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <returns>The result (NewX_AVM-DE_PhoneName) of the action.</returns>
    public string X_AVM_DE_GetPhonePort(ushort newIndex)
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetDelayedCallNotification.
    /// </summary>
    /// <param name="newX_AVM_DE_ClientIndex">The SOAP parameter NewX_AVM-DE_ClientIndex.</param>
    /// <param name="newX_AVM_DE_DelayedCallNotification">The SOAP parameter NewX_AVM-DE_DelayedCallNotification.</param>
    public void X_AVM_DE_SetDelayedCallNotification(ushort newX_AVM_DE_ClientIndex, bool newX_AVM_DE_DelayedCallNotification)
    {
    }

    /// <summary>
    /// Wrapper for the action GetVoIPCommonCountryCode.
    /// </summary>
    /// <returns>The result (NewVoIPCountryCode) of the action.</returns>
    public string GetVoIPCommonCountryCode()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetVoIPCommonCountryCode.
    /// </summary>
    /// <returns>The result (X_AVM_DE_GetVoIPCommonCountryCodeResult) of the action.</returns>
    public X_AVM_DE_GetVoIPCommonCountryCodeResult X_AVM_DE_GetVoIPCommonCountryCode()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action SetVoIPCommonCountryCode.
    /// </summary>
    /// <param name="newVoIPCountryCode">The SOAP parameter NewVoIPCountryCode.</param>
    public void SetVoIPCommonCountryCode(string newVoIPCountryCode)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetVoIPCommonCountryCode.
    /// </summary>
    /// <param name="newX_AVM_DE_LKZ">The SOAP parameter NewX_AVM-DE_LKZ.</param>
    /// <param name="newX_AVM_DE_LKZPrefix">The SOAP parameter NewX_AVM-DE_LKZPrefix.</param>
    public void X_AVM_DE_SetVoIPCommonCountryCode(string newX_AVM_DE_LKZ, string newX_AVM_DE_LKZPrefix)
    {
    }

    /// <summary>
    /// Wrapper for the action GetVoIPEnableCountryCode.
    /// </summary>
    /// <param name="newVoIPAccountIndex">The SOAP parameter NewVoIPAccountIndex.</param>
    /// <returns>The result (NewVoIPEnableCountryCode) of the action.</returns>
    public bool GetVoIPEnableCountryCode(ushort newVoIPAccountIndex)
    {
      return false;
    }

    /// <summary>
    /// Wrapper for the action SetVoIPEnableCountryCode.
    /// </summary>
    /// <param name="newVoIPAccountIndex">The SOAP parameter NewVoIPAccountIndex.</param>
    /// <param name="newVoIPEnableCountryCode">The SOAP parameter NewVoIPEnableCountryCode.</param>
    public void SetVoIPEnableCountryCode(ushort newVoIPAccountIndex, bool newVoIPEnableCountryCode)
    {
    }

    /// <summary>
    /// Wrapper for the action GetVoIPCommonAreaCode.
    /// </summary>
    /// <returns>The result (NewVoIPAreaCode) of the action.</returns>
    public string GetVoIPCommonAreaCode()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetVoIPCommonAreaCode.
    /// </summary>
    /// <returns>The result (X_AVM_DE_GetVoIPCommonAreaCodeResult) of the action.</returns>
    public X_AVM_DE_GetVoIPCommonAreaCodeResult X_AVM_DE_GetVoIPCommonAreaCode()
    {
      return null;
    }

    /// <summary>
    /// Wrapper for the action SetVoIPCommonAreaCode.
    /// </summary>
    /// <param name="newVoIPAreaCode">The SOAP parameter NewVoIPAreaCode.</param>
    public void SetVoIPCommonAreaCode(string newVoIPAreaCode)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetVoIPCommonAreaCode.
    /// </summary>
    /// <param name="newX_AVM_DE_OKZ">The SOAP parameter NewX_AVM-DE_OKZ.</param>
    /// <param name="newX_AVM_DE_OKZPrefix">The SOAP parameter NewX_AVM-DE_OKZPrefix.</param>
    public void X_AVM_DE_SetVoIPCommonAreaCode(string newX_AVM_DE_OKZ, string newX_AVM_DE_OKZPrefix)
    {
    }

    /// <summary>
    /// Wrapper for the action GetVoIPEnableAreaCode.
    /// </summary>
    /// <param name="newVoIPAccountIndex">The SOAP parameter NewVoIPAccountIndex.</param>
    /// <returns>The result (NewVoIPEnableAreaCode) of the action.</returns>
    public bool GetVoIPEnableAreaCode(ushort newVoIPAccountIndex)
    {
      return false;
    }

    /// <summary>
    /// Wrapper for the action SetVoIPEnableAreaCode.
    /// </summary>
    /// <param name="newVoIPAccountIndex">The SOAP parameter NewVoIPAccountIndex.</param>
    /// <param name="newVoIPEnableAreaCode">The SOAP parameter NewVoIPEnableAreaCode.</param>
    public void SetVoIPEnableAreaCode(ushort newVoIPAccountIndex, bool newVoIPEnableAreaCode)
    {
    }
  }
}
