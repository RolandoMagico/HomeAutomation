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
  using System.Xml.Linq;

  /// <summary>
  /// Enveloper for SOAP serialization.
  /// </summary>
  public class Envelope : BaseSoapXmlElement
  {
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

    /// <summary>
    /// Gets the default namespace for this element.
    /// </summary>
    internal static XNamespace DefaultNamespace { get; } = "http://schemas.xmlsoap.org/soap/envelope/";

    /// <inheritdoc/>
    protected override void ReadXmlInternal(XContainer container)
    {
      if (container.Element(DefaultNamespace + nameof(Envelope)) is XElement envelope)
      {
        if (envelope.Element(DefaultNamespace + nameof(this.Header)) is XElement headerXml)
        {
          this.Header = new Header();
          this.Header.ReadXml(headerXml);
        }

        if (envelope.Element(DefaultNamespace + nameof(this.Body)) is XElement bodyXml)
        {
          this.Body = new Body();
          this.Body.ReadXml(bodyXml);
        }
      }
    }

    /// <inheritdoc/>
    protected override void WriteXmlInternal(XContainer container)
    {
      XElement envelope = new XElement(
        DefaultNamespace + nameof(Envelope),
        new XAttribute(XNamespace.Xmlns + DefaultNamespacePrefix, DefaultNamespace),
        new XAttribute(DefaultNamespace + "encodingStyle", "http://schemas.xmlsoap.org/soap/encoding/"));
      container.Add(envelope);

      this.Header?.WriteXml(envelope);
      this.Body?.WriteXml(envelope);
    }
  }
}
