import base64

from Crypto.Cipher import AES


def decrypt_vulcan_qr_base64(content_encrypted: str, password: str) -> str:
    content_encrypted += (len(content_encrypted) % 4) * '='
    data = base64.b64decode(content_encrypted)
    return decrypt_vulcan_qr_bytes(data, password)


def decrypt_vulcan_qr_bytes(bcontent: bytearray, password: str) -> str:
    decipher = AES.new(password, AES.MODE_ECB)
    content_bytes: bytearray = decipher.decrypt(bcontent)
    content_text = content_bytes.decode('utf-8')
    return content_text
