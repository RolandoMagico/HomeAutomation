// <copyright file="Body.cs" company="ContextQuickie">
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
  using System.Xml.Serialization;

  /// <summary>
  /// Class for creating a SOAP request.
  /// </summary>
  public class Body : ISoapXmlElement
  {
    /// <summary>
    /// The default namespace prefix.
    /// </summary>
    internal const string DefaultNamespacePrefix = "u";

    /// <summary>
    /// Initializes a new instance of the <see cref="Body"/> class.
    /// This default constructor should only be used by XML serialization.
    /// </summary>
    public Body()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Body"/> class.
    /// </summary>
    /// <param name="service">The service for this request.</param>
    /// <param name="action">The action for this request.</param>
    public Body(SoapService service, SoapAction action)
    {
      this.Action = action;
      this.Service = service;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Body"/> class.
    /// </summary>
    /// <param name="operation">The operation for this request.</param>
    public Body(SoapOperation operation)
    {
      this.Action = operation.Action;
      this.Service = operation.Service;
    }

    /// <summary>
    /// Gets or sets the service.
    /// </summary>
    [XmlIgnore]
    public SoapService Service { get; set; }

    /// <summary>
    /// Gets or sets the action.
    /// </summary>
    [XmlIgnore]
    public SoapAction Action { get; set; }

    /// <summary>
    /// Gets or sets the fault.
    /// </summary>
    public Fault Fault { get; set; }

    /// <inheritdoc/>
    public void ReadXml(XContainer container)
    {
      if (container.Element(Envelope.DefaultNamespace + nameof(this.Fault)) is XElement faultXml)
      {
        this.Fault = new Fault();
        this.Fault.ReadXml(faultXml);
      }
    }

    /// <inheritdoc/>
    public void WriteXml(XContainer container)
    {
      XNamespace defaultNamespace = this.Service.ServiceType;
      XElement body = new XElement(Envelope.DefaultNamespace + nameof(Body));
      body.Add(new XElement(
        defaultNamespace + this.Action.Name,
        new XAttribute(XNamespace.Xmlns + DefaultNamespacePrefix, defaultNamespace)));
      container.Add(body);

      this.Fault?.WriteXml(body);
    }
  }
}
