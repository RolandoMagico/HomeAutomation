// <copyright file="X_AVM_DE_Homeplug.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_Homeplug:1.
  /// </summary>
  public class X_AVM_DE_Homeplug : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:X_AVM-DE_Homeplug:1";

    /// <summary>
    /// Wrapper for the action GetNumberOfDeviceEntries.
    /// </summary>
    /// <returns>The result (NewNumberOfEntries) of the action.</returns>
    public ushort GetNumberOfDeviceEntries()
    {
      return this.SendRequest<ushort>("GetNumberOfDeviceEntries");
    }

    /// <summary>
    /// Wrapper for the action GetGenericDeviceEntry.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <returns>The result (X_AVM_DE_HomeplugGetGenericDeviceEntryResult) of the action.</returns>
    public X_AVM_DE_HomeplugGetGenericDeviceEntryResult GetGenericDeviceEntry(ushort newIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      return this.SendRequest<X_AVM_DE_HomeplugGetGenericDeviceEntryResult>("GetGenericDeviceEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetSpecificDeviceEntry.
    /// </summary>
    /// <param name="newMACAddress">The SOAP parameter NewMACAddress.</param>
    /// <returns>The result (X_AVM_DE_HomeplugGetSpecificDeviceEntryResult) of the action.</returns>
    public X_AVM_DE_HomeplugGetSpecificDeviceEntryResult GetSpecificDeviceEntry(string newMACAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewMACAddress", newMACAddress);
      return this.SendRequest<X_AVM_DE_HomeplugGetSpecificDeviceEntryResult>("GetSpecificDeviceEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action DeviceDoUpdate.
    /// </summary>
    /// <param name="newMACAddress">The SOAP parameter NewMACAddress.</param>
    public void DeviceDoUpdate(string newMACAddress)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewMACAddress", newMACAddress);
      this.SendRequest("DeviceDoUpdate", arguments);
    }
  }
}
