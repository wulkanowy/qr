import unittest

import wulkanowy_qr

PASSWORD = "0123456789ABCDEF"
CONTENT = "CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT"
ENCODED = "27Grk6d8ZDely5eeF7j2ngWrWV9eZa5Dz9ZmuiBavysDp74TCr6EHJOs6TaIXFh3HsROWSM11pv3cPvRGSi7Nw=="


class TestEncoding(unittest.TestCase):
    def test_encode(self) -> None:
        self.assertEqual(wulkanowy_qr.encode(PASSWORD, CONTENT), ENCODED)

    def test_decode(self) -> None:
        self.assertEqual(wulkanowy_qr.decode(PASSWORD, ENCODED), CONTENT)

    def test_both(self) -> None:
        self.assertEqual(
            CONTENT,
            wulkanowy_qr.decode(PASSWORD, wulkanowy_qr.encode(PASSWORD, CONTENT)),
        )


if __name__ == "__main__":
    unittest.main()
