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
namespace HomeAutomation
{
  using FritzControl;
  using FritzControl.Soap;
  using HomeAutomationLib;
  using NLog;
  using NLog.Common;

  /// <summary>
  /// Entry class of the application.
  /// </summary>
  public class Program : BaseLogger
  {
    /// <summary>
    /// Entry method of the application.
    /// </summary>
    /// <param name="args">The program arguments.</param>
    public static void Main(string[] args)
    {
#if DEBUG
      InternalLogger.LogToConsole = true;
#endif

      // Example
      // FritzBox fritzBox = new FritzBox { Username = "YourUsername", Password = "Yourpassword", Hostname = "fritz.box" };
      FritzBox fritzBox = new FritzBox();
      fritzBox.Connect();
      X_AVM_DE_Dect dect = new X_AVM_DE_Dect { FritzBox = fritzBox };
      ushort numberOfDectEntries = dect.GetNumberOfDectEntries();
      for (ushort i = 0; i < numberOfDectEntries; i++)
      {
        GetGenericDectEntryResult genericResult = dect.GetGenericDectEntry(i);
        Log.Info($"DECT device index {i}");
        Log.Info($"Model: {genericResult.NewModel}");
        Log.Info($"Model: {genericResult.NewName}");
      }

      LogManager.Shutdown();
    }
  }
}
