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
  using FritzControl.Soap;
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
      { DataType.UnsignedInt4Bytes, "uint" },
      { DataType.UUID, typeof(Guid).FullName }
    };

    /// <summary>
    /// Dictionary to map from SOAP data tyes default return values.
    /// Ony required temporary until the implementation of the function is done.
    /// </summary>
    private static Dictionary<DataType, string> returnValueMapping = new Dictionary<DataType, string>
    {
      { DataType.Boolean, "false" },
      { DataType.DateTime, typeof(DateTime).FullName },
      { DataType.SignedInt4Bytes, "0" },
      { DataType.UnsignedInt1Byte, "0" },
      { DataType.UnsignedInt2Bytes, "0" },
      { DataType.UnsignedInt4Bytes, "0" },
      { DataType.UUID, "System.Guid.Empty" }
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

      // Just for testing: Serialize current description to XML
      // new System.Xml.Serialization.XmlSerializer(fritzBox.Description.GetType()).Serialize(new StreamWriter("Description.xml"), fritzBox.Description);
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
        string typeName = soapService.ServiceType.Substring(start, end - start + 1);
        typeName = typeName.Replace("-", "_");
        string filename = Path.Combine(targetDirectory, typeName + ".cs");
        this.GenerateFileHeader(filename, targetNamespace, typeName, $"Wrapper for the service {soapService.ServiceType}.", nameof(BaseService));
        using (StreamWriter writer = new StreamWriter(filename, true))
        {
          writer.WriteLine($@"    /// <inheritdoc/>");
          writer.WriteLine($@"    protected override string ServiceType {{ get; }} = ""{soapService.ServiceType}"";");
          writer.WriteLine();

          foreach (SoapAction action in soapService.Scpd.Actions)
          {
            writer.WriteLine($"    /// <summary>");
            writer.WriteLine($"    /// Wrapper for the action {action.Name}.");
            writer.WriteLine($"    /// </summary>");
            List<string> parameters = new List<string>();
            var inArguments = action.Arguments.Where(a => a.Direction == Direction.In);
            foreach (Argument argument in inArguments)
            {
              string parameterName = this.ConvertArgumentNameToParameterName(argument.Name);
              ServiceStateVariable serviceStateVariable = soapService.Scpd.StateVariables.First(sv => sv.Name == argument.RelatedStateVariable);
              if (serviceStateVariable.AllowedValues.Any())
              {
                writer.WriteLine($@"    /// <param name=""{parameterName}"">The SOAP parameter {argument.Name}. Allowed values: {string.Join(", ", serviceStateVariable.AllowedValues)}.</param>");
              }
              else
              {
                writer.WriteLine($@"    /// <param name=""{parameterName}"">The SOAP parameter {argument.Name}.</param>");
              }

              parameters.Add($"{dataTypeMapping[serviceStateVariable.DataType]} {parameterName}");
            }

            string actionName = action.Name.Replace("-", "_");
            string returnType = "void";
            string defaultReturnValue = "null";
            var outArguments = action.Arguments.Where(a => a.Direction == Direction.Out);
            if (outArguments.Count() == 1)
            {
              Argument argument = outArguments.First();
              ServiceStateVariable serviceStateVariable = soapService.Scpd.StateVariables.First(sv => sv.Name == argument.RelatedStateVariable);
              returnType = dataTypeMapping[serviceStateVariable.DataType];
              writer.WriteLine($"    /// <returns>The result ({argument.Name}) of the action.</returns>");
              if (returnValueMapping.ContainsKey(serviceStateVariable.DataType))
              {
                defaultReturnValue = returnValueMapping[serviceStateVariable.DataType];
              }
            }
            else if (outArguments.Count() > 1)
            {
              returnType = this.GenerateResultType(typeName, actionName, targetDirectory, targetNamespace, outArguments, soapService.Scpd.StateVariables);
              writer.WriteLine($"    /// <returns>The result ({returnType}) of the action.</returns>");
            }

            writer.WriteLine($"    public {returnType} {actionName}({string.Join(", ", parameters)})");
            writer.WriteLine($"    {{");
            string secondParameter = string.Empty;
            if (inArguments.Any())
            {
              secondParameter = ", arguments";
              writer.WriteLine($@"      System.Collections.Generic.Dictionary<string, object> arguments = new System.Collections.Generic.Dictionary<string, object>();");
              foreach (Argument argument in inArguments)
              {
                writer.WriteLine($@"      arguments.Add(""{argument.Name}"", {this.ConvertArgumentNameToParameterName(argument.Name)});");
              }
            }

            if (outArguments.Any())
            {
              writer.WriteLine($@"      return this.SendRequest<{returnType}>(""{action.Name}""{secondParameter});");
            }
            else
            {
              writer.WriteLine($@"      this.SendRequest(""{action.Name}""{secondParameter});");
            }

            writer.WriteLine($"    }}");
            if (action != soapService.Scpd.Actions.Last())
            {
              writer.WriteLine();
            }
          }
        }

        this.GenerateFileFooter(filename);
      }

      foreach (Device d in device.Devices)
      {
        int end = d.DeviceType.LastIndexOf(":") - 1;
        int start = d.DeviceType.LastIndexOf(":", end) + 1;
        string directoryName = d.DeviceType.Substring(start, end - start + 1);
        this.GenerateServiceWrapper(Path.Combine(targetDirectory, directoryName), targetNamespace + "." + directoryName, d);
      }
    }

    /// <summary>
    /// Generate a class for retrieving the result of a SOAP opeartion.
    /// </summary>
    /// <param name="serviceTypeName">The name of the class which implements the corresponding service.</param>
    /// <param name="actionName">The action for which a result type will be generated.</param>
    /// <param name="targetDirectory">The directory to which the wrapper will be generated.</param>
    /// <param name="targetNamespace">The namespace to which the wrapper will be generated.</param>
    /// <param name="elements">The elements of the type.</param>
    /// <param name="stateVariables">The state variables for this type.</param>
    /// <returns>The name of the generated type.</returns>
    private string GenerateResultType(string serviceTypeName, string actionName, string targetDirectory, string targetNamespace, IEnumerable<Argument> elements, List<ServiceStateVariable> stateVariables)
    {
      string typeName = serviceTypeName + actionName + "Result";
      string filename = Path.Combine(targetDirectory, typeName + ".cs");
      this.GenerateFileHeader(filename, targetNamespace, typeName, $"Result type for {actionName} in service {serviceTypeName}.");
      using (StreamWriter writer = new StreamWriter(filename, true))
      {
        foreach (Argument element in elements)
        {
          ServiceStateVariable serviceStateVariable = stateVariables.First(sv => sv.Name == element.RelatedStateVariable);
          writer.WriteLine($"    /// <summary>");
          if (serviceStateVariable.DataType == DataType.Boolean)
          {
            writer.WriteLine($"    /// Gets or sets a value indicating whether the SOAP argument {element.Name} is set or not.");
          }
          else
          {
            writer.WriteLine($"    /// Gets or sets the SOAP argument {element.Name}.");
          }

          writer.WriteLine($"    /// </summary>");
          writer.WriteLine($@"    [System.Xml.Serialization.XmlElement(""{element.Name}"")]");
          writer.WriteLine($"    public {dataTypeMapping[serviceStateVariable.DataType]} {element.Name.Replace("-", "_")} {{ get; set; }}");
          if (element != elements.Last())
          {
            writer.WriteLine();
          }
        }
      }

      this.GenerateFileFooter(filename);
      return typeName;
    }

    /// <summary>
    /// Generates a file header.
    /// </summary>
    /// <param name="filename">The file to which the content will be generated.</param>
    /// <param name="targetNamespace">The namespace to which the wrapper will be generated.</param>
    /// <param name="typeName">The name of the type in this file.</param>
    /// <param name="typeDescription">The XML description for the type.</param>
    /// <param name="baseClass">The base class from which the generated class will inherit.</param>
    private void GenerateFileHeader(string filename, string targetNamespace, string typeName, string typeDescription, string baseClass = null)
    {
      using (StreamWriter writer = new StreamWriter(filename))
      {
        writer.WriteLine(string.Format(fileHeader, typeName));
        writer.WriteLine($"namespace {targetNamespace}");
        writer.WriteLine($"{{");
        writer.WriteLine($"  /// <summary>");
        writer.WriteLine($"  /// {typeDescription}");
        writer.WriteLine($"  /// </summary>");
        if (baseClass != null)
        {
          writer.WriteLine($"  public class {typeName} : {baseClass}");
        }
        else
        {
          writer.WriteLine($"  public class {typeName}");
        }

        writer.WriteLine($"  {{");
      }
    }

    /// <summary>
    /// Generates a file footer.
    /// </summary>
    /// <param name="filename">The file to which the content will be generated.</param>
    private void GenerateFileFooter(string filename)
    {
      using (StreamWriter writer = new StreamWriter(filename, true))
      {
        writer.WriteLine($"  }}");
        writer.WriteLine($"}}");
      }
    }

    /// <summary>
    /// Converts an <see cref="Argument"/> name to an C# parameter name.
    /// </summary>
    /// <param name="argumentName">The name of the argument</param>
    /// <returns>The name of the C# parameter.</returns>
    private string ConvertArgumentNameToParameterName(string argumentName)
    {
      string parameterName = argumentName.Replace("-", "_");
      parameterName = parameterName[0].ToString().ToLower() + parameterName.Substring(1);
      return parameterName;
    }
  }
}
