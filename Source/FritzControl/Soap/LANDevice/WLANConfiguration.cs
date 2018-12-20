// <copyright file="WLANConfiguration.cs" company="ContextQuickie">
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
namespace FritzControl.Soap.LANDevice
{
  /// <summary>
  /// Wrapper for the service urn:dslforum-org:service:WLANConfiguration:3
  /// </summary>
  public class WLANConfiguration
  {
    /// <summary>
    /// Wrapper for the action SetEnable
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetEnable(bool newEnable)
    {
    }

    /// <summary>
    /// Wrapper for the action GetInfo
    /// </summary>
    public void GetInfo()
    {
    }

    /// <summary>
    /// Wrapper for the action SetConfig
    /// </summary>
    /// <param name="newMaxBitRate">The SOAP parameter NewMaxBitRate.</param>
    /// <param name="newChannel">The SOAP parameter NewChannel.</param>
    /// <param name="newSSID">The SOAP parameter NewSSID.</param>
    /// <param name="newBeaconType">The SOAP parameter NewBeaconType.</param>
    /// <param name="newMACAddressControlEnabled">The SOAP parameter NewMACAddressControlEnabled.</param>
    /// <param name="newBasicEncryptionModes">The SOAP parameter NewBasicEncryptionModes.</param>
    /// <param name="newBasicAuthenticationMode">The SOAP parameter NewBasicAuthenticationMode.</param>
    public void SetConfig(string newMaxBitRate, byte newChannel, string newSSID, string newBeaconType, bool newMACAddressControlEnabled, string newBasicEncryptionModes, string newBasicAuthenticationMode)
    {
    }

    /// <summary>
    /// Wrapper for the action SetSecurityKeys
    /// </summary>
    /// <param name="newWEPKey0">The SOAP parameter NewWEPKey0.</param>
    /// <param name="newWEPKey1">The SOAP parameter NewWEPKey1.</param>
    /// <param name="newWEPKey2">The SOAP parameter NewWEPKey2.</param>
    /// <param name="newWEPKey3">The SOAP parameter NewWEPKey3.</param>
    /// <param name="newPreSharedKey">The SOAP parameter NewPreSharedKey.</param>
    /// <param name="newKeyPassphrase">The SOAP parameter NewKeyPassphrase.</param>
    public void SetSecurityKeys(string newWEPKey0, string newWEPKey1, string newWEPKey2, string newWEPKey3, string newPreSharedKey, string newKeyPassphrase)
    {
    }

    /// <summary>
    /// Wrapper for the action GetSecurityKeys
    /// </summary>
    public void GetSecurityKeys()
    {
    }

    /// <summary>
    /// Wrapper for the action SetDefaultWEPKeyIndex
    /// </summary>
    /// <param name="newDefaultWEPKeyIndex">The SOAP parameter NewDefaultWEPKeyIndex.</param>
    public void SetDefaultWEPKeyIndex(byte newDefaultWEPKeyIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action GetDefaultWEPKeyIndex
    /// </summary>
    public void GetDefaultWEPKeyIndex()
    {
    }

    /// <summary>
    /// Wrapper for the action SetBasBeaconSecurityProperties
    /// </summary>
    /// <param name="newBasicEncryptionModes">The SOAP parameter NewBasicEncryptionModes.</param>
    /// <param name="newBasicAuthenticationMode">The SOAP parameter NewBasicAuthenticationMode.</param>
    public void SetBasBeaconSecurityProperties(string newBasicEncryptionModes, string newBasicAuthenticationMode)
    {
    }

    /// <summary>
    /// Wrapper for the action GetBasBeaconSecurityProperties
    /// </summary>
    public void GetBasBeaconSecurityProperties()
    {
    }

    /// <summary>
    /// Wrapper for the action GetStatistics
    /// </summary>
    public void GetStatistics()
    {
    }

    /// <summary>
    /// Wrapper for the action GetPacketStatistics
    /// </summary>
    public void GetPacketStatistics()
    {
    }

    /// <summary>
    /// Wrapper for the action GetBSSID
    /// </summary>
    public void GetBSSID()
    {
    }

    /// <summary>
    /// Wrapper for the action GetSSID
    /// </summary>
    public void GetSSID()
    {
    }

    /// <summary>
    /// Wrapper for the action SetSSID
    /// </summary>
    /// <param name="newSSID">The SOAP parameter NewSSID.</param>
    public void SetSSID(string newSSID)
    {
    }

    /// <summary>
    /// Wrapper for the action GetBeaconType
    /// </summary>
    public void GetBeaconType()
    {
    }

    /// <summary>
    /// Wrapper for the action SetBeaconType
    /// </summary>
    /// <param name="newBeaconType">The SOAP parameter NewBeaconType.</param>
    public void SetBeaconType(string newBeaconType)
    {
    }

    /// <summary>
    /// Wrapper for the action GetChannelInfo
    /// </summary>
    public void GetChannelInfo()
    {
    }

    /// <summary>
    /// Wrapper for the action SetChannel
    /// </summary>
    /// <param name="newChannel">The SOAP parameter NewChannel.</param>
    public void SetChannel(byte newChannel)
    {
    }

    /// <summary>
    /// Wrapper for the action GetBeaconAdvertisement
    /// </summary>
    public void GetBeaconAdvertisement()
    {
    }

    /// <summary>
    /// Wrapper for the action SetBeaconAdvertisement
    /// </summary>
    /// <param name="newBeaconAdvertisementEnabled">The SOAP parameter NewBeaconAdvertisementEnabled.</param>
    public void SetBeaconAdvertisement(bool newBeaconAdvertisementEnabled)
    {
    }

    /// <summary>
    /// Wrapper for the action GetTotalAssociations
    /// </summary>
    public void GetTotalAssociations()
    {
    }

    /// <summary>
    /// Wrapper for the action GetGenericAssociatedDeviceInfo
    /// </summary>
    /// <param name="newAssociatedDeviceIndex">The SOAP parameter NewAssociatedDeviceIndex.</param>
    public void GetGenericAssociatedDeviceInfo(ushort newAssociatedDeviceIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action GetSpecificAssociatedDeviceInfo
    /// </summary>
    /// <param name="newAssociatedDeviceMACAddress">The SOAP parameter NewAssociatedDeviceMACAddress.</param>
    public void GetSpecificAssociatedDeviceInfo(string newAssociatedDeviceMACAddress)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetSpecificAssociatedDeviceInfoByIp
    /// </summary>
    /// <param name="newAssociatedDeviceIPAddress">The SOAP parameter NewAssociatedDeviceIPAddress.</param>
    public void X_AVM_DE_GetSpecificAssociatedDeviceInfoByIp(string newAssociatedDeviceIPAddress)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetStickSurfEnable
    /// </summary>
    /// <param name="newStickSurfEnable">The SOAP parameter NewStickSurfEnable.</param>
    public void X_AVM_DE_SetStickSurfEnable(bool newStickSurfEnable)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetIPTVOptimized
    /// </summary>
    public void X_AVM_DE_GetIPTVOptimized()
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetIPTVOptimized
    /// </summary>
    /// <param name="newX_AVM_DE_IPTVoptimize">The SOAP parameter NewX_AVM-DE_IPTVoptimize.</param>
    public void X_AVM_DE_SetIPTVOptimized(bool newX_AVM_DE_IPTVoptimize)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetNightControl
    /// </summary>
    public void X_AVM_DE_GetNightControl()
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetWLANHybridMode
    /// </summary>
    public void X_AVM_DE_GetWLANHybridMode()
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetWLANHybridMode
    /// </summary>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    /// <param name="newBeaconType">The SOAP parameter NewBeaconType.</param>
    /// <param name="newKeyPassphrase">The SOAP parameter NewKeyPassphrase.</param>
    /// <param name="newSSID">The SOAP parameter NewSSID.</param>
    /// <param name="newBSSID">The SOAP parameter NewBSSID.</param>
    /// <param name="newTrafficMode">The SOAP parameter NewTrafficMode.</param>
    /// <param name="newManualSpeed">The SOAP parameter NewManualSpeed.</param>
    /// <param name="newMaxSpeedDS">The SOAP parameter NewMaxSpeedDS.</param>
    /// <param name="newMaxSpeedUS">The SOAP parameter NewMaxSpeedUS.</param>
    public void X_AVM_DE_SetWLANHybridMode(bool newEnable, string newBeaconType, string newKeyPassphrase, string newSSID, string newBSSID, string newTrafficMode, bool newManualSpeed, uint newMaxSpeedDS, uint newMaxSpeedUS)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetWLANExtInfo
    /// </summary>
    public void X_AVM_DE_GetWLANExtInfo()
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetWPSInfo
    /// </summary>
    public void X_AVM_DE_GetWPSInfo()
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetWPSConfig
    /// </summary>
    /// <param name="newX_AVM_DE_WPSMode">The SOAP parameter NewX_AVM-DE_WPSMode.</param>
    /// <param name="newX_AVM_DE_WPSClientPIN">The SOAP parameter NewX_AVM-DE_WPSClientPIN.</param>
    public void X_AVM_DE_SetWPSConfig(string newX_AVM_DE_WPSMode, string newX_AVM_DE_WPSClientPIN)
    {
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetWLANGlobalEnable
    /// </summary>
    /// <param name="newX_AVM_DE_WLANGlobalEnable">The SOAP parameter NewX_AVM-DE_WLANGlobalEnable.</param>
    public void X_AVM_DE_SetWLANGlobalEnable(bool newX_AVM_DE_WLANGlobalEnable)
    {
    }
  }
}
