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
  /// Wrapper for the service urn:dslforum-org:service:WLANConfiguration:3.
  /// </summary>
  public class WLANConfiguration : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:WLANConfiguration:3";

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
    /// Wrapper for the action GetInfo.
    /// </summary>
    /// <returns>The result (WLANConfigurationGetInfoResult) of the action.</returns>
    public WLANConfigurationGetInfoResult GetInfo()
    {
      return this.SendRequest<WLANConfigurationGetInfoResult>("GetInfo");
    }

    /// <summary>
    /// Wrapper for the action SetConfig.
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
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewMaxBitRate", newMaxBitRate);
      arguments.Add("NewChannel", newChannel);
      arguments.Add("NewSSID", newSSID);
      arguments.Add("NewBeaconType", newBeaconType);
      arguments.Add("NewMACAddressControlEnabled", newMACAddressControlEnabled);
      arguments.Add("NewBasicEncryptionModes", newBasicEncryptionModes);
      arguments.Add("NewBasicAuthenticationMode", newBasicAuthenticationMode);
      this.SendRequest("SetConfig", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetSecurityKeys.
    /// </summary>
    /// <param name="newWEPKey0">The SOAP parameter NewWEPKey0.</param>
    /// <param name="newWEPKey1">The SOAP parameter NewWEPKey1.</param>
    /// <param name="newWEPKey2">The SOAP parameter NewWEPKey2.</param>
    /// <param name="newWEPKey3">The SOAP parameter NewWEPKey3.</param>
    /// <param name="newPreSharedKey">The SOAP parameter NewPreSharedKey.</param>
    /// <param name="newKeyPassphrase">The SOAP parameter NewKeyPassphrase.</param>
    public void SetSecurityKeys(string newWEPKey0, string newWEPKey1, string newWEPKey2, string newWEPKey3, string newPreSharedKey, string newKeyPassphrase)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewWEPKey0", newWEPKey0);
      arguments.Add("NewWEPKey1", newWEPKey1);
      arguments.Add("NewWEPKey2", newWEPKey2);
      arguments.Add("NewWEPKey3", newWEPKey3);
      arguments.Add("NewPreSharedKey", newPreSharedKey);
      arguments.Add("NewKeyPassphrase", newKeyPassphrase);
      this.SendRequest("SetSecurityKeys", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetSecurityKeys.
    /// </summary>
    /// <returns>The result (WLANConfigurationGetSecurityKeysResult) of the action.</returns>
    public WLANConfigurationGetSecurityKeysResult GetSecurityKeys()
    {
      return this.SendRequest<WLANConfigurationGetSecurityKeysResult>("GetSecurityKeys");
    }

    /// <summary>
    /// Wrapper for the action SetDefaultWEPKeyIndex.
    /// </summary>
    /// <param name="newDefaultWEPKeyIndex">The SOAP parameter NewDefaultWEPKeyIndex.</param>
    public void SetDefaultWEPKeyIndex(byte newDefaultWEPKeyIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewDefaultWEPKeyIndex", newDefaultWEPKeyIndex);
      this.SendRequest("SetDefaultWEPKeyIndex", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetDefaultWEPKeyIndex.
    /// </summary>
    /// <returns>The result (NewDefaultWEPKeyIndex) of the action.</returns>
    public byte GetDefaultWEPKeyIndex()
    {
      return this.SendRequest<byte>("GetDefaultWEPKeyIndex");
    }

    /// <summary>
    /// Wrapper for the action SetBasBeaconSecurityProperties.
    /// </summary>
    /// <param name="newBasicEncryptionModes">The SOAP parameter NewBasicEncryptionModes.</param>
    /// <param name="newBasicAuthenticationMode">The SOAP parameter NewBasicAuthenticationMode.</param>
    public void SetBasBeaconSecurityProperties(string newBasicEncryptionModes, string newBasicAuthenticationMode)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewBasicEncryptionModes", newBasicEncryptionModes);
      arguments.Add("NewBasicAuthenticationMode", newBasicAuthenticationMode);
      this.SendRequest("SetBasBeaconSecurityProperties", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetBasBeaconSecurityProperties.
    /// </summary>
    /// <returns>The result (WLANConfigurationGetBasBeaconSecurityPropertiesResult) of the action.</returns>
    public WLANConfigurationGetBasBeaconSecurityPropertiesResult GetBasBeaconSecurityProperties()
    {
      return this.SendRequest<WLANConfigurationGetBasBeaconSecurityPropertiesResult>("GetBasBeaconSecurityProperties");
    }

    /// <summary>
    /// Wrapper for the action GetStatistics.
    /// </summary>
    /// <returns>The result (WLANConfigurationGetStatisticsResult) of the action.</returns>
    public WLANConfigurationGetStatisticsResult GetStatistics()
    {
      return this.SendRequest<WLANConfigurationGetStatisticsResult>("GetStatistics");
    }

    /// <summary>
    /// Wrapper for the action GetPacketStatistics.
    /// </summary>
    /// <returns>The result (WLANConfigurationGetPacketStatisticsResult) of the action.</returns>
    public WLANConfigurationGetPacketStatisticsResult GetPacketStatistics()
    {
      return this.SendRequest<WLANConfigurationGetPacketStatisticsResult>("GetPacketStatistics");
    }

    /// <summary>
    /// Wrapper for the action GetBSSID.
    /// </summary>
    /// <returns>The result (NewBSSID) of the action.</returns>
    public string GetBSSID()
    {
      return this.SendRequest<string>("GetBSSID");
    }

    /// <summary>
    /// Wrapper for the action GetSSID.
    /// </summary>
    /// <returns>The result (NewSSID) of the action.</returns>
    public string GetSSID()
    {
      return this.SendRequest<string>("GetSSID");
    }

    /// <summary>
    /// Wrapper for the action SetSSID.
    /// </summary>
    /// <param name="newSSID">The SOAP parameter NewSSID.</param>
    public void SetSSID(string newSSID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewSSID", newSSID);
      this.SendRequest("SetSSID", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetBeaconType.
    /// </summary>
    /// <returns>The result (NewBeaconType) of the action.</returns>
    public string GetBeaconType()
    {
      return this.SendRequest<string>("GetBeaconType");
    }

    /// <summary>
    /// Wrapper for the action SetBeaconType.
    /// </summary>
    /// <param name="newBeaconType">The SOAP parameter NewBeaconType.</param>
    public void SetBeaconType(string newBeaconType)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewBeaconType", newBeaconType);
      this.SendRequest("SetBeaconType", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetChannelInfo.
    /// </summary>
    /// <returns>The result (WLANConfigurationGetChannelInfoResult) of the action.</returns>
    public WLANConfigurationGetChannelInfoResult GetChannelInfo()
    {
      return this.SendRequest<WLANConfigurationGetChannelInfoResult>("GetChannelInfo");
    }

    /// <summary>
    /// Wrapper for the action SetChannel.
    /// </summary>
    /// <param name="newChannel">The SOAP parameter NewChannel.</param>
    public void SetChannel(byte newChannel)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewChannel", newChannel);
      this.SendRequest("SetChannel", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetBeaconAdvertisement.
    /// </summary>
    /// <returns>The result (NewBeaconAdvertisementEnabled) of the action.</returns>
    public bool GetBeaconAdvertisement()
    {
      return this.SendRequest<bool>("GetBeaconAdvertisement");
    }

    /// <summary>
    /// Wrapper for the action SetBeaconAdvertisement.
    /// </summary>
    /// <param name="newBeaconAdvertisementEnabled">The SOAP parameter NewBeaconAdvertisementEnabled.</param>
    public void SetBeaconAdvertisement(bool newBeaconAdvertisementEnabled)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewBeaconAdvertisementEnabled", newBeaconAdvertisementEnabled);
      this.SendRequest("SetBeaconAdvertisement", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetTotalAssociations.
    /// </summary>
    /// <returns>The result (NewTotalAssociations) of the action.</returns>
    public ushort GetTotalAssociations()
    {
      return this.SendRequest<ushort>("GetTotalAssociations");
    }

    /// <summary>
    /// Wrapper for the action GetGenericAssociatedDeviceInfo.
    /// </summary>
    /// <param name="newAssociatedDeviceIndex">The SOAP parameter NewAssociatedDeviceIndex.</param>
    /// <returns>The result (WLANConfigurationGetGenericAssociatedDeviceInfoResult) of the action.</returns>
    public WLANConfigurationGetGenericAssociatedDeviceInfoResult GetGenericAssociatedDeviceInfo(ushort newAssociatedDeviceIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAssociatedDeviceIndex", newAssociatedDeviceIndex);
      return this.SendRequest<WLANConfigurationGetGenericAssociatedDeviceInfoResult>("GetGenericAssociatedDeviceInfo", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetSpecificAssociatedDeviceInfo.
    /// </summary>
    /// <param name="newAssociatedDeviceMACAddress">The SOAP parameter NewAssociatedDeviceMACAddress.</param>
    /// <returns>The result (WLANConfigurationGetSpecificAssociatedDeviceInfoResult) of the action.</returns>
    public WLANConfigurationGetSpecificAssociatedDeviceInfoResult GetSpecificAssociatedDeviceInfo(string newAssociatedDeviceMACAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAssociatedDeviceMACAddress", newAssociatedDeviceMACAddress);
      return this.SendRequest<WLANConfigurationGetSpecificAssociatedDeviceInfoResult>("GetSpecificAssociatedDeviceInfo", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetSpecificAssociatedDeviceInfoByIp.
    /// </summary>
    /// <param name="newAssociatedDeviceIPAddress">The SOAP parameter NewAssociatedDeviceIPAddress.</param>
    /// <returns>The result (WLANConfigurationX_AVM_DE_GetSpecificAssociatedDeviceInfoByIpResult) of the action.</returns>
    public WLANConfigurationX_AVM_DE_GetSpecificAssociatedDeviceInfoByIpResult X_AVM_DE_GetSpecificAssociatedDeviceInfoByIp(string newAssociatedDeviceIPAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewAssociatedDeviceIPAddress", newAssociatedDeviceIPAddress);
      return this.SendRequest<WLANConfigurationX_AVM_DE_GetSpecificAssociatedDeviceInfoByIpResult>("X_AVM-DE_GetSpecificAssociatedDeviceInfoByIp", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetStickSurfEnable.
    /// </summary>
    /// <param name="newStickSurfEnable">The SOAP parameter NewStickSurfEnable.</param>
    public void X_AVM_DE_SetStickSurfEnable(bool newStickSurfEnable)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewStickSurfEnable", newStickSurfEnable);
      this.SendRequest("X_AVM-DE_SetStickSurfEnable", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetIPTVOptimized.
    /// </summary>
    /// <returns>The result (NewX_AVM-DE_IPTVoptimize) of the action.</returns>
    public bool X_AVM_DE_GetIPTVOptimized()
    {
      return this.SendRequest<bool>("X_AVM-DE_GetIPTVOptimized");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetIPTVOptimized.
    /// </summary>
    /// <param name="newX_AVM_DE_IPTVoptimize">The SOAP parameter NewX_AVM-DE_IPTVoptimize.</param>
    public void X_AVM_DE_SetIPTVOptimized(bool newX_AVM_DE_IPTVoptimize)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewX_AVM-DE_IPTVoptimize", newX_AVM_DE_IPTVoptimize);
      this.SendRequest("X_AVM-DE_SetIPTVOptimized", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetNightControl.
    /// </summary>
    /// <returns>The result (WLANConfigurationX_AVM_DE_GetNightControlResult) of the action.</returns>
    public WLANConfigurationX_AVM_DE_GetNightControlResult X_AVM_DE_GetNightControl()
    {
      return this.SendRequest<WLANConfigurationX_AVM_DE_GetNightControlResult>("X_AVM-DE_GetNightControl");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetWLANHybridMode.
    /// </summary>
    /// <returns>The result (WLANConfigurationX_AVM_DE_GetWLANHybridModeResult) of the action.</returns>
    public WLANConfigurationX_AVM_DE_GetWLANHybridModeResult X_AVM_DE_GetWLANHybridMode()
    {
      return this.SendRequest<WLANConfigurationX_AVM_DE_GetWLANHybridModeResult>("X_AVM-DE_GetWLANHybridMode");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetWLANHybridMode.
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
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewEnable", newEnable);
      arguments.Add("NewBeaconType", newBeaconType);
      arguments.Add("NewKeyPassphrase", newKeyPassphrase);
      arguments.Add("NewSSID", newSSID);
      arguments.Add("NewBSSID", newBSSID);
      arguments.Add("NewTrafficMode", newTrafficMode);
      arguments.Add("NewManualSpeed", newManualSpeed);
      arguments.Add("NewMaxSpeedDS", newMaxSpeedDS);
      arguments.Add("NewMaxSpeedUS", newMaxSpeedUS);
      this.SendRequest("X_AVM-DE_SetWLANHybridMode", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetWLANExtInfo.
    /// </summary>
    /// <returns>The result (WLANConfigurationX_AVM_DE_GetWLANExtInfoResult) of the action.</returns>
    public WLANConfigurationX_AVM_DE_GetWLANExtInfoResult X_AVM_DE_GetWLANExtInfo()
    {
      return this.SendRequest<WLANConfigurationX_AVM_DE_GetWLANExtInfoResult>("X_AVM-DE_GetWLANExtInfo");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_GetWPSInfo.
    /// </summary>
    /// <returns>The result (WLANConfigurationX_AVM_DE_GetWPSInfoResult) of the action.</returns>
    public WLANConfigurationX_AVM_DE_GetWPSInfoResult X_AVM_DE_GetWPSInfo()
    {
      return this.SendRequest<WLANConfigurationX_AVM_DE_GetWPSInfoResult>("X_AVM-DE_GetWPSInfo");
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetWPSConfig.
    /// </summary>
    /// <param name="newX_AVM_DE_WPSMode">The SOAP parameter NewX_AVM-DE_WPSMode.</param>
    /// <param name="newX_AVM_DE_WPSClientPIN">The SOAP parameter NewX_AVM-DE_WPSClientPIN.</param>
    /// <returns>The result (WLANConfigurationX_AVM_DE_SetWPSConfigResult) of the action.</returns>
    public WLANConfigurationX_AVM_DE_SetWPSConfigResult X_AVM_DE_SetWPSConfig(string newX_AVM_DE_WPSMode, string newX_AVM_DE_WPSClientPIN)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewX_AVM-DE_WPSMode", newX_AVM_DE_WPSMode);
      arguments.Add("NewX_AVM-DE_WPSClientPIN", newX_AVM_DE_WPSClientPIN);
      return this.SendRequest<WLANConfigurationX_AVM_DE_SetWPSConfigResult>("X_AVM-DE_SetWPSConfig", arguments);
    }

    /// <summary>
    /// Wrapper for the action X_AVM-DE_SetWLANGlobalEnable.
    /// </summary>
    /// <param name="newX_AVM_DE_WLANGlobalEnable">The SOAP parameter NewX_AVM-DE_WLANGlobalEnable.</param>
    public void X_AVM_DE_SetWLANGlobalEnable(bool newX_AVM_DE_WLANGlobalEnable)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewX_AVM-DE_WLANGlobalEnable", newX_AVM_DE_WLANGlobalEnable);
      this.SendRequest("X_AVM-DE_SetWLANGlobalEnable", arguments);
    }
  }
}
