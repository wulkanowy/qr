# UONET+ QR Code converter for Python

[![PyPI](https://img.shields.io/pypi/v/wulkanowy-qr.svg?style=flat-square)](https://pypi.org/project/wulkanowy-qr/)

## Installation

```
pip install wulkanowy-qr
```

## Usage

```pycon
>>> import wulkanowy_qr
>>> wulkanowy_qr.encode("0123456789ABCDEF", "CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT")
'27Grk6d8ZDely5eeF7j2ngWrWV9eZa5Dz9ZmuiBavysDp74TCr6EHJOs6TaIXFh3HsROWSM11pv3cPvRGSi7Nw=='
>>> wulkanowy_qr.decode("0123456789ABCDEF", "27Grk6d8ZDely5eeF7j2ngWrWV9eZa5Dz9ZmuiBavysDp74TCr6EHJOs6TaIXFh3HsROWSM11pv3cPvRGSi7Nw==")
'CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT'
```
