# vulcan-qr

## Usage

```swift
import VulcanQR

let parser = try VulcanQR(password: password)

let encoded = parser.encrypt(Data(content.utf8))
let decoded = parser.decryptToString(base64)
```

## Tests

Just run it in Xcode or use `xcodebuild` in terminal
