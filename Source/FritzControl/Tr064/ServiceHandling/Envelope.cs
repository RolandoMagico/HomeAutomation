// <copyright file="Envelope.cs" company="ContextQuickie">
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
  using System.Xml.Serialization;

  /// <summary>
  /// Enveloper for SOAP serialization.
  /// </summary>
  public class Envelope : ISoapXmlElement
  {
    /// <summary>
    /// The default namespace for serialization.
    /// </summary>
    [XmlIgnore]
    internal const string DefaultNamespace = "http://schemas.xmlsoap.org/soap/envelope/";

    /// <summary>
    /// The default namespace prefix.
    /// </summary>
    internal const string DefaultNamespacePrefix = "s";

    /// <summary>
    /// Gets or sets the header of the envelope.
    /// </summary>
    public Header Header { get; set; }

    /// <summary>
    /// Gets or sets the request in the envelope.
    /// </summary>
    public Body Body { get; set; }

    /// <inheritdoc/>
    public void ReadXml(XElement element)
    {
    }

    /// <inheritdoc/>
    public void WriteXml(XmlWriter writer)
    {
      writer.WriteStartElement(DefaultNamespacePrefix, nameof(Envelope), DefaultNamespace);
      writer.WriteAttributeString("encodingStyle", DefaultNamespace, "http://schemas.xmlsoap.org/soap/encoding/");

      this.Header?.WriteXml(writer);
      this.Body?.WriteXml(writer);

      writer.WriteEndElement();
    }
  }
}
