# UONET+ Qr Code converter for .NET

## Usage
```csharp
using Wulkanowy;

var encode = Qr.Encode("PASSWORD", "CODE");
var decode = Qr.Decode("PASSWORD", "ENCRYPTED_CODE");
```

## Test
```bash
$ dotnet test WulkanowyQr.Test
```
