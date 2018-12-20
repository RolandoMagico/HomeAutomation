// <copyright file="BaseService.cs" company="ContextQuickie">
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
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Reflection;
  using System.Xml.Serialization;
  using FritzControl.Tr064;
  using FritzControl.Tr064.ServiceHandling;

  /// <summary>
  /// Base class for all services.
  /// </summary>
  public abstract class BaseService
  {
    /// <summary>
    /// Gets or sets the <see cref="FritzBox"/> instance which is used for the communication.
    /// </summary>
    public FritzBox FritzBox { get; set; }

    /// <summary>
    /// Gets the service type of this class.
    /// </summary>
    protected abstract string ServiceType { get; }

    /// <summary>
    /// Sends a request wihtout arguments to the fritz box.
    /// </summary>
    /// <param name="actionName">The name of the action.</param>
    /// <param name="arguments">The optional arguments of the action.</param>
    protected void SendRequest(string actionName, Dictionary<string, object> arguments = null)
    {
      if (this.FritzBox.Description.Device.GetSoapOperation(this.ServiceType, actionName) is SoapOperation operation)
      {
        Header initChallenge = new Header { UserId = this.FritzBox.Username, InitialChanllenge = false };
        Body body = new Body(operation);
        if (arguments != null)
        {
          body.Arguments = arguments;
        }

        Request request = new Request { Header = initChallenge, Body = body };
        this.FritzBox.SendSoapRequest(request);
      }
    }

    /// <summary>
    /// Sends a request wihtout arguments to the fritz box.
    /// </summary>
    /// <param name="actionName">The name of the action.</param>
    /// <param name="arguments">The optional arguments of the action.</param>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    /// <returns>The received response data or <c>null</c> if no response had been received.</returns>
    protected TResult SendRequest<TResult>(string actionName, Dictionary<string, object> arguments = null)
    {
      if (this.FritzBox.Description.Device.GetSoapOperation(this.ServiceType, actionName) is SoapOperation operation)
      {
        Header initChallenge = new Header { UserId = this.FritzBox.Username, InitialChanllenge = false };
        Body body = new Body(operation);
        if (arguments != null)
        {
          body.Arguments = arguments;
        }

        Request request = new Request { Header = initChallenge, Body = body };
        if (this.FritzBox.SendSoapRequest(request) is Response response)
        {
          if (response.Body.Arguments.Count == 1)
          {
            return (TResult)response.Body.Arguments.Values.First();
          }
          else if (response.Body.Arguments.Count > 1)
          {
            TResult result = (TResult)Activator.CreateInstance(typeof(TResult));

            foreach (PropertyInfo propertyInfo in result.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
              if (propertyInfo.GetCustomAttribute<XmlElementAttribute>() is XmlElementAttribute attribute)
              {
                propertyInfo.SetValue(result, response.Body.Arguments[attribute.ElementName]);
              }
            }

            return result;
          }
        }
      }

      return default(TResult);
    }
  }
}
