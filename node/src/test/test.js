const vulcanQR = require('../index');
const assert = require('assert');

const password = '0123456789ABCDEF';
const content = 'CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT';
const base64 = '27Grk6d8ZDely5eeF7j2ngWrWV9eZa5Dz9ZmuiBavysDp74TCr6EHJOs6TaIXFh3HsROWSM11pv3cPvRGSi7Nw==';

describe('encoder', () => {
  it('encodes', () => {
    const result = vulcanQR.encode(password, content);
    assert.equal(result, base64);
  });
});

describe('decoder', () => {
  it('decodes', () => {
    const result = vulcanQR.decode(password, base64);
    assert.equal(result, content);
  });
});
