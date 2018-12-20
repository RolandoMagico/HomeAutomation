# HomeAutomation
Just another example how to access Fritz Box services

## Example: Reading all DECT devices
```csharp
FritzBox fritzBox = new FritzBox { Username = "YourUsername", Password = "Yourpassword", Hostname = "fritz.box" };
fritzBox.Connect();
X_AVM_DE_Dect dect = new X_AVM_DE_Dect { FritzBox = fritzBox };
ushort numberOfDectEntries = dect.GetNumberOfDectEntries();
for (ushort i = 0; i < numberOfDectEntries; i++)
{
  var result = dect.GetGenericDectEntry(i);
  Log.Info($"DECT device index {i}");
  Log.Info($"Model: {result.NewModel}");
  Log.Info($"Model: {result.NewName}");
}
```

## Example: Switching on a Fritz!Dect 200 device
```csharp
FritzBox fritzBox = new FritzBox { Username = "YourUsername", Password = "Yourpassword", Hostname = "fritz.box" };
fritzBox.Connect();
X_AVM_DE_Dect dect = new X_AVM_DE_Dect { FritzBox = fritzBox };
ushort numberOfDectEntries = dect.GetNumberOfDectEntries();
for (ushort i = 0; i < numberOfDectEntries; i++)
{
  var genericResult = dect.GetGenericDectEntry(i);
  if (genericResult.NewName == "Wohnzimmer")
  {
    X_AVM_DE_Homeauto homeAuto = new X_AVM_DE_Homeauto { FritzBox = fritzBox };
    var result = homeAuto.GetGenericDeviceInfos(i);
    homeAuto.SetSwitch(result.NewAIN, "ON");
  }
}
```
