// <copyright file="Header.cs" company="ContextQuickie">
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

namespace FritzControl.Tr064.ServiceHandling
{
  using System.Xml;
  using System.Xml.Linq;

  /// <summary>
  /// Header data for a SOAP request.
  /// </summary>
  public class Header : ISoapXmlElement
  {
    /// <summary>
    /// Gets or sets the user ID.
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or sets the nonce for authentification.
    /// </summary>
    public string Nonce { get; set; }

    /// <summary>
    /// Gets or sets the token for authentification.
    /// </summary>
    public string AuthToken { get; set; }

    /// <summary>
    /// Gets or sets the realm for authentification.
    /// </summary>
    public string Realm { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this header is for the initial challenge or not.
    /// </summary>
    public bool InitialChanllenge { get; set; }

    /// <inheritdoc/>
    public void ReadXml(XElement element)
    {
    }

    /// <inheritdoc/>
    public void WriteXml(XmlWriter writer)
    {
      writer.WriteStartElement(nameof(Header), Envelope.DefaultNamespace);
      if (this.InitialChanllenge)
      {
        writer.WriteStartElement("h", "InitChallenge", "http://soap-authentication.org/digest/2001/10/");
      }
      else
      {
        writer.WriteStartElement("h", "ClientAuth", "http://soap-authentication.org/digest/2001/10/");
      }

      writer.WriteAttributeString("mustunderstand", Envelope.DefaultNamespace, "1");
      if (this.Nonce != null)
      {
        writer.WriteElementString(nameof(this.Nonce), this.Nonce);
      }

      if (this.AuthToken != null)
      {
        writer.WriteElementString("Auth", this.AuthToken);
      }

      if (this.UserId != null)
      {
        writer.WriteElementString("UserID", this.UserId);
      }

      if (this.Realm != null)
      {
        writer.WriteElementString(nameof(this.Realm), this.Realm);
      }

      writer.WriteEndElement();
      writer.WriteEndElement();
    }
  }
}
