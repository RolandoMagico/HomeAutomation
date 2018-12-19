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
  using System;
  using System.Collections.Generic;
  using System.Linq;
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
    /// </summary>
    /// <param name="parent">The parent request or response of this body.</param>
    public Body(Envelope parent)
    {
      this.Parent = parent;
      if (this.Parent is Response response)
      {
        this.Action = response.Request.Body.Action;
        this.Service = response.Request.Body.Service;
      }
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
    /// Gets the arguments for the <see cref="Action"/>.
    /// </summary>
    public Dictionary<string, object> Arguments { get; private set; } = new Dictionary<string, object>();

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

    /// <summary>
    /// Gets the parent envelope of this instance.
    /// </summary>
    public Envelope Parent { get; }

    /// <inheritdoc/>
    public void ReadXml(XContainer container)
    {
      if (container.Element(Envelope.DefaultNamespace + nameof(this.Fault)) is XElement faultXml)
      {
        this.Fault = new Fault();
        this.Fault.ReadXml(faultXml);
      }

      if (this.Parent is Response response)
      {
        XNamespace serviceNamespace = this.Service.ServiceType;
        if (container.Element(serviceNamespace + this.Action.Name + "Response") is XElement serviceXml)
        {
          foreach (XElement element in serviceXml.Elements())
          {
            string argumentName = element.Name.LocalName;
            if (this.Action.Arguments.FirstOrDefault(a => a.Name == argumentName) is Argument argument &&
                this.Service.Scpd.StateVariables.FirstOrDefault(v => v.Name == argument.RelatedStateVariable) is ServiceStateVariable serviceStateVariable)
            {
              switch (serviceStateVariable.DataType)
              {
                case DataType.Boolean:
                  int elementValueInt;
                  bool elementValueBool;
                  if (bool.TryParse(element.Value, out elementValueBool))
                  {
                    this.Arguments.Add(element.Name.LocalName, elementValueBool);
                  }
                  else if (int.TryParse(element.Value, out elementValueInt))
                  {
                    this.Arguments.Add(element.Name.LocalName, Convert.ToBoolean(elementValueInt));
                  }
                  else
                  {
                    throw new ArgumentOutOfRangeException(nameof(DataType), element.Value, $@"Cannot convert string ""{element.Value}"" to a boolean value");
                  }

                  break;
                case DataType.String:
                  this.Arguments.Add(element.Name.LocalName, element.Value);
                  break;
                case DataType.UnsignedInt2Bytes:
                  this.Arguments.Add(element.Name.LocalName, ushort.Parse(element.Value));
                  break;
                case DataType.UnsignedInt4Bytes:
                  this.Arguments.Add(element.Name.LocalName, uint.Parse(element.Value));
                  break;
                default:
                  throw new ArgumentOutOfRangeException(nameof(DataType), serviceStateVariable.DataType, "Unsupported state variable type");
              }
            }
          }
        }
      }
    }

    /// <inheritdoc/>
    public void WriteXml(XContainer container)
    {
      XNamespace defaultNamespace = this.Service.ServiceType;
      XElement body = new XElement(Envelope.DefaultNamespace + nameof(Body));
      XElement action = new XElement(
        defaultNamespace + this.Action.Name,
        new XAttribute(XNamespace.Xmlns + DefaultNamespacePrefix, defaultNamespace));

      foreach (string argument in this.Action.Arguments.Where(a => a.Direction == Direction.In).Select(a => a.Name))
      {
        if (this.Arguments.ContainsKey(argument))
        {
          action.Add(new XElement(argument, this.Arguments[argument]));
        }
        else
        {
          throw new ArgumentException("Missing input argument", argument);
        }
      }

      body.Add(action);
      container.Add(body);
      this.Fault?.WriteXml(body);
    }
  }
}
