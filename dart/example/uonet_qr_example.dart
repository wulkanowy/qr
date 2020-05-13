import 'package:uonet_qr/uonet_qr.dart' as qr;

void main() {

	final password = '0123456789ABCDEF';
	final rawContent = 'CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT';
	final base64Content = '27Grk6d8ZDely5eeF7j2ngWrWV9eZa5Dz9ZmuiBavysDp74TCr6EHJOs6TaIXFh3HsROWSM11pv3cPvRGSi7Nw==';

	final decoded = qr.decode(password, base64Content);

	final encoded = qr.encode(password, rawContent);
}
