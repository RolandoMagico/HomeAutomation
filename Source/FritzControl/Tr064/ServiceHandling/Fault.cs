// <copyright file="Fault.cs" company="ContextQuickie">
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
  /// Fault in a <see cref="Body"/> element.
  /// </summary>
  public class Fault : ISoapXmlElement
  {
    /// <summary>
    /// Gets or sets the error code.
    /// </summary>
    public int ErrorCode { get; set; }

    /// <summary>
    /// Gets or sets the error description.
    /// </summary>
    public string ErrorDescription { get; set; }

    /// <inheritdoc/>
    public void ReadXml(XContainer container)
    {
      if (container.Element("errorCode") is XElement errorCodeXml)
      {
        this.ErrorCode = int.Parse(errorCodeXml.Value);
      }

      if (container.Element("errorDescription") is XElement errorDescriptionXml)
      {
        this.ErrorDescription = errorDescriptionXml.Value;
      }
    }

    /// <inheritdoc/>
    public void WriteXml(XContainer container)
    {
      XElement fault = new XElement(Envelope.DefaultNamespace + nameof(Fault));
      fault.Add(new XElement("errorCode", this.ErrorCode));
      fault.Add(new XElement("errorDescription", this.ErrorDescription));
      container.Add(fault);
    }
  }
}
