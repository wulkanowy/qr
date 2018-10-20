# UONET+ QR Code converter

[![](https://jitpack.io/v/wulkanowy/qr.svg)](https://jitpack.io/#wulkanowy/qr)

## Instalation

```grovy
allprojects {
    repositories {
        maven { url 'https://jitpack.io' }
    }
}

dependencies {
    implementation 'com.github.wulkanowy:qr:master-SNAPSHOT'
}
```

## Usage

```kotlin
import io.github.wulkanowy.qr.decode
import io.github.wulkanowy.qr.encode

val decoded = decode(password, content)

val encoded = encode(password, decoded)
```

## Tests

```bash
$ ./gradlew test
```
