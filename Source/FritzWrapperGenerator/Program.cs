// <copyright file="Program.cs" company="ContextQuickie">
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
namespace FritzWrapperGenerator
{
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Linq;
  using System.Reflection;
  using FritzControl;
  using FritzControl.Tr064;

  /// <summary>
  /// Entry class of the application.
  /// </summary>
  public class Program
  {
    /// <summary>
    /// The file header for each generated source file.
    /// </summary>
    private static string fileHeader;

    /// <summary>
    /// Dictionary to map from SOAP data tyes to C# data tyes.
    /// </summary>
    private static Dictionary<DataType, string> dataTypeMapping = new Dictionary<DataType, string>
    {
      { DataType.Boolean, "bool" },
      { DataType.DateTime, typeof(DateTime).FullName },
      { DataType.String, "string" },
      { DataType.SignedInt4Bytes, "int" },
      { DataType.UnsignedInt1Byte, "byte" },
      { DataType.UnsignedInt2Bytes, "ushort" },
      { DataType.UnsignedInt4Bytes, "uint" }
    };

    /// <summary>
    /// Entry method of the application.
    /// </summary>
    /// <param name="args">The program arguments.</param>
    public static void Main(string[] args)
    {
      FritzBox fritzBox = new FritzBox();
      fritzBox.Connect();

      fileHeader = File.ReadAllText("FileHeader.txt");
      string targetDirectory = Path.GetFullPath(Path.Combine(Assembly.GetEntryAssembly().Location, "./../../../../../FritzControl/Soap"));
      new Program().GenerateServiceWrapper(targetDirectory, "FritzControl.Soap", fritzBox.Description.Device);
    }

    /// <summary>
    /// Generates the service wrapper for the specific device.
    /// </summary>
    /// <param name="targetDirectory">The directory to which the wrapper will be generated.</param>
    /// <param name="targetNamespace">The namespace to which the wrapper will be generated.</param>
    /// <param name="device">The device.</param>
    private void GenerateServiceWrapper(string targetDirectory, string targetNamespace, Device device)
    {
      if (Directory.Exists(targetDirectory) == false)
      {
        Directory.CreateDirectory(targetDirectory);
      }

      foreach (SoapService soapService in device.Services)
      {
        int end = soapService.ServiceType.LastIndexOf(":") - 1;
        int start = soapService.ServiceType.LastIndexOf(":", end) + 1;
        string className = soapService.ServiceType.Substring(start, end - start + 1);
        className = className.Replace("-", "_");
        using (StreamWriter writer = new StreamWriter(Path.Combine(targetDirectory, className + ".cs")))
        {
          writer.WriteLine(string.Format(fileHeader, className));
          writer.WriteLine($"namespace {targetNamespace}");
          writer.WriteLine($"{{");
          writer.WriteLine($"  /// <summary>");
          writer.WriteLine($"  /// Wrapper for the service {soapService.ServiceType}");
          writer.WriteLine($"  /// </summary>");
          writer.WriteLine($"  public class {className}");
          writer.WriteLine($"  {{");

          foreach (SoapAction action in soapService.Scpd.Actions)
          {
            writer.WriteLine($"    /// <summary>");
            writer.WriteLine($"    /// Wrapper for the action {action.Name}");
            writer.WriteLine($"    /// </summary>");
            List<string> arguments = new List<string>();
            foreach (Argument argument in action.Arguments.Where(a => a.Direction == Direction.In))
            {
              string argumentName = argument.Name.Replace("-", "_");
              argumentName = argumentName[0].ToString().ToLower() + argumentName.Substring(1);
              writer.WriteLine($@"    /// <param name=""{argumentName}"">The SOAP parameter {argument.Name}.</param>");
              ServiceStateVariable serviceStateVariable = soapService.Scpd.StateVariables.First(sv => sv.Name == argument.RelatedStateVariable);
              arguments.Add($"{dataTypeMapping[serviceStateVariable.DataType]} {argumentName}");
            }

            writer.WriteLine($"    public void {action.Name.Replace("-", "_")}({string.Join(", ", arguments)})");
            writer.WriteLine($"    {{");
            writer.WriteLine($"    }}");
            if (action != soapService.Scpd.Actions.Last())
            {
              writer.WriteLine();
            }
          }

          writer.WriteLine($"  }}");
          writer.WriteLine($"}}");
        }
      }

      foreach (Device d in device.Devices)
      {
        int end = d.DeviceType.LastIndexOf(":") - 1;
        int start = d.DeviceType.LastIndexOf(":", end) + 1;
        string directoryName = d.DeviceType.Substring(start, end - start + 1);
        this.GenerateServiceWrapper(Path.Combine(targetDirectory, directoryName), targetNamespace + "." + directoryName, d);
      }
    }
  }
}
