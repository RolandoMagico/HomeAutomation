// <copyright file="X_AVM_DE_Filelinks.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_Filelinks:1.
  /// </summary>
  public class X_AVM_DE_Filelinks : BaseService
  {
    /// <inheritdoc/>
    protected override string ServiceType { get; } = "urn:dslforum-org:service:X_AVM-DE_Filelinks:1";

    /// <summary>
    /// Wrapper for the action GetNumberOfFilelinkEntries.
    /// </summary>
    /// <returns>The result (NewNumberOfEntries) of the action.</returns>
    public ushort GetNumberOfFilelinkEntries()
    {
      return this.SendRequest<ushort>("GetNumberOfFilelinkEntries");
    }

    /// <summary>
    /// Wrapper for the action GetGenericFilelinkEntry.
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <returns>The result (GetGenericFilelinkEntryResult) of the action.</returns>
    public GetGenericFilelinkEntryResult GetGenericFilelinkEntry(ushort newIndex)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewIndex", newIndex);
      return this.SendRequest<GetGenericFilelinkEntryResult>("GetGenericFilelinkEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetSpecificFilelinkEntry.
    /// </summary>
    /// <param name="newID">The SOAP parameter NewID.</param>
    /// <returns>The result (GetSpecificFilelinkEntryResult) of the action.</returns>
    public GetSpecificFilelinkEntryResult GetSpecificFilelinkEntry(string newID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewID", newID);
      return this.SendRequest<GetSpecificFilelinkEntryResult>("GetSpecificFilelinkEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action NewFilelinkEntry.
    /// </summary>
    /// <param name="newPath">The SOAP parameter NewPath.</param>
    /// <param name="newAccessCountLimit">The SOAP parameter NewAccessCountLimit.</param>
    /// <param name="newExpire">The SOAP parameter NewExpire.</param>
    /// <returns>The result (NewID) of the action.</returns>
    public string NewFilelinkEntry(string newPath, ushort newAccessCountLimit, ushort newExpire)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewPath", newPath);
      arguments.Add("NewAccessCountLimit", newAccessCountLimit);
      arguments.Add("NewExpire", newExpire);
      return this.SendRequest<string>("NewFilelinkEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action SetFilelinkEntry.
    /// </summary>
    /// <param name="newID">The SOAP parameter NewID.</param>
    /// <param name="newAccessCountLimit">The SOAP parameter NewAccessCountLimit.</param>
    /// <param name="newExpire">The SOAP parameter NewExpire.</param>
    public void SetFilelinkEntry(string newID, ushort newAccessCountLimit, ushort newExpire)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewID", newID);
      arguments.Add("NewAccessCountLimit", newAccessCountLimit);
      arguments.Add("NewExpire", newExpire);
      this.SendRequest("SetFilelinkEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action DeleteFilelinkEntry.
    /// </summary>
    /// <param name="newID">The SOAP parameter NewID.</param>
    public void DeleteFilelinkEntry(string newID)
    {
      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();
      arguments.Add("NewID", newID);
      this.SendRequest("DeleteFilelinkEntry", arguments);
    }

    /// <summary>
    /// Wrapper for the action GetFilelinkListPath.
    /// </summary>
    /// <returns>The result (NewFilelinkListPath) of the action.</returns>
    public string GetFilelinkListPath()
    {
      return this.SendRequest<string>("GetFilelinkListPath");
    }
  }
}
