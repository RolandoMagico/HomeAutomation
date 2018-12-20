// <copyright file="X_AVM_DE_TAM.cs" company="ContextQuickie">
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
  /// Wrapper for the service urn:dslforum-org:service:X_AVM-DE_TAM:1
  /// </summary>
  public class X_AVM_DE_TAM
  {
    /// <summary>
    /// Wrapper for the action GetInfo
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    public void GetInfo(ushort newIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action SetEnable
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <param name="newEnable">The SOAP parameter NewEnable.</param>
    public void SetEnable(ushort newIndex, bool newEnable)
    {
    }

    /// <summary>
    /// Wrapper for the action GetMessageList
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    public void GetMessageList(ushort newIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action MarkMessage
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <param name="newMessageIndex">The SOAP parameter NewMessageIndex.</param>
    /// <param name="newMarkedAsRead">The SOAP parameter NewMarkedAsRead.</param>
    public void MarkMessage(ushort newIndex, ushort newMessageIndex, bool newMarkedAsRead)
    {
    }

    /// <summary>
    /// Wrapper for the action DeleteMessage
    /// </summary>
    /// <param name="newIndex">The SOAP parameter NewIndex.</param>
    /// <param name="newMessageIndex">The SOAP parameter NewMessageIndex.</param>
    public void DeleteMessage(ushort newIndex, ushort newMessageIndex)
    {
    }

    /// <summary>
    /// Wrapper for the action GetList
    /// </summary>
    public void GetList()
    {
    }
  }
}
