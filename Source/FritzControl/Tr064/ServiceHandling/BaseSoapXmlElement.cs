// <copyright file="BaseSoapXmlElement.cs" company="ContextQuickie">
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
  using HomeAutomationLib;

  /// <summary>
  /// Base class for classes implementing <see cref="ISoapXmlElement"/>
  /// </summary>
  public abstract class BaseSoapXmlElement : BaseLogger, ISoapXmlElement
  {
    /// <summary>
    /// Gets the XML container for this element.
    /// </summary>
    public XContainer XmlContainer { get; private set; }

    /// <inheritdoc/>
    public void ReadXml(XContainer container)
    {
      this.XmlContainer = container;
      this.ReadXmlInternal(container);
    }

    /// <inheritdoc/>
    public void WriteXml(XContainer container)
    {
      this.XmlContainer = container;
      this.WriteXmlInternal(container);
    }

    /// <summary>
    /// Generates an object from its SOAP XML representation.
    /// </summary>
    /// <param name="container">The <see cref="XElement"/> element from which the object is deserialized.</param>
    protected abstract void ReadXmlInternal(XContainer container);

    /// <summary>
    /// Converts an object into its SOAP XML representation.
    /// </summary>
    /// <param name="container">The <see cref="XContainer"/> to which the object is serialized.</param>
    protected abstract void WriteXmlInternal(XContainer container);

    /// <summary>
    /// Gets the string value of a child element of <paramref name="parent"/>.
    /// </summary>
    /// <param name="parent">The parent container.</param>
    /// <param name="childName">The name of the child.</param>
    /// <returns>The value of the child element or <c>null</c> if the child with the specific name doesn't exist.</returns>
    protected string GetChildElementValue(XContainer parent, string childName)
    {
      if (parent.Element(childName) is XElement element)
      {
        return element.Value;
      }

      return null;
    }

    /// <summary>
    /// Sets the string value of a child element of <paramref name="parent"/>.
    /// </summary>
    /// <param name="parent">The parent container.</param>
    /// <param name="childName">The name of the child.</param>
    /// <param name="childValue">The value of the child elemet.</param>
    protected void SetChildElementValue(XContainer parent, string childName, string childValue)
    {
      if (childValue != null)
      {
        parent.Add(new XElement(childName, childValue));
      }
    }
  }
}
