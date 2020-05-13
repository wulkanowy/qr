import 'package:uonet_qr/uonet_qr.dart';
import 'package:test/test.dart';

void main() {
	final password = '0123456789ABCDEF';
	final content = 'CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT';
	final base64 = '27Grk6d8ZDely5eeF7j2ngWrWV9eZa5Dz9ZmuiBavysDp74TCr6EHJOs6TaIXFh3HsROWSM11pv3cPvRGSi7Nw==';

	test('Encode', () {
		final encoded = encode(password, content);
		expect(encoded, base64);
	});

	test('Decode', () {
		final decoded = decode(password, base64);
		expect(decoded, content);
	});
}
