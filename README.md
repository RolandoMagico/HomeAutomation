# HomeAutomation
Just another example how to access Fritz Box services

## Example: Reading all DECT devices
```ruby
FritzBox fritzBox = new FritzBox { Username = "YourUsername", Password = "Yourpassword", Hostname = "fritz.box" };
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
```
