const crypto = require('crypto');

const ALGORITHM = 'aes-128-ecb';
const UTF8 = 'utf-8';
const BASE64 = 'base64';

const toArrayBuffer = (str) => new TextEncoder().encode(str);

const encode = (password, content) => {
  const cipher = crypto.createCipheriv(ALGORITHM, toArrayBuffer(password), Buffer.alloc(0));
  let encrypted = cipher.update(content, UTF8, BASE64);
  encrypted += cipher.final(BASE64);
  return encrypted;
};

const decode = (password, content) => {
  const decipher = crypto.createDecipheriv(ALGORITHM, toArrayBuffer(password), Buffer.alloc(0));
  let decrypted = decipher.update(content, BASE64, UTF8);
  decrypted += decipher.final(UTF8);
  return decrypted;
};

module.exports = {
  encode,
  decode,
  __esModule: true,
};
