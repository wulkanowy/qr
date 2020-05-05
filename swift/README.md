# UONET+ QR Code converter

## Installation
**Check requirements from Podfile!**

Now just add it as a target for you app or prebuild `.framework` and attach it to target

> just wait for release on the CocoaPods

## Usage 
```swift
let qr = try! VulcanQR(password: "vifuwoxoje")
let dectyptedValue = qr.decryptToString(Data(base64Encoded: base64QRString)!)
```