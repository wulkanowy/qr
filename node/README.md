# UONET+ QR Code converter for Node.js

[![npm](https://img.shields.io/npm/v/@wulkanowy/qr-node.svg?style=flat-square)](https://www.npmjs.com/package/@wulkanowy/qr-node)


## Instalation

```bash
$ npm i @wulkanowy/qr-node
```

## Usage

```js
const qr = require('@wulkanowy/qr-node');

const decoded = qr.decode(password, base64Content);

const encoded = qr.encode(password, rawContent);
```

See example in [tests](test.js)

## Tests

```bash
$ npm run test
```
