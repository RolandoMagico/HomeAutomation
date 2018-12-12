// <copyright file="SoapOperation.cs" company="ContextQuickie">
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

namespace FritzControl.Tr064
{
  /// <summary>
  /// Class for storing a <see cref="SoapService"/> and a <see cref="SoapAction"/>.
  /// </summary>
  public class SoapOperation
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="SoapOperation"/> class.
    /// </summary>
    /// <param name="service">The service of the operation.</param>
    /// <param name="action">The action of the operation.</param>
    public SoapOperation(SoapService service, SoapAction action)
    {
      this.Service = service;
      this.Action = action;
    }

    /// <summary>
    /// Gets the service of this operation.
    /// </summary>
    public SoapService Service { get; }

    /// <summary>
    /// Gets the action of this operation.
    /// </summary>
    public SoapAction Action { get; }
  }
}
