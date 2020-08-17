import 'package:encrypt/encrypt.dart';

/// Decode a qr code
String decode(String password, String content) {
	final key = Key.fromUtf8(password);
  final encrypter = Encrypter(AES(key, mode: AESMode.ecb));
  final enc = Encrypted.fromBase64(content);
  final decoded = encrypter.decrypt(enc);
  return decoded;
}

String encode(String password, String content) {
	final key = Key.fromUtf8(password);
  final encrypter = Encrypter(AES(key, mode: AESMode.ecb));
  final encoded = encrypter.encrypt(content);
  return encoded.base64;
}
