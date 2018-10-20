# UONET+ QR Code converter for PHP

[![Total Downloads](https://poser.pugx.org/wulkanowy/qr/downloads?format=flat-square)](https://packagist.org/packages/wulkanowy/qr)

## Instalation

```bash
$ composer require wulkanowy/qr dev-master
```

## Usage

```php
<?php

use function Wulkanowy\UonetQRCodeConverter\decode;
use function Wulkanowy\UonetQRCodeConverter\encode;

require 'vendor/autoload.php';

$decoded = decode($password, $content);

$encoded = encode($password, $decoded);
```

## Tests

```bash
$ composer test
```
