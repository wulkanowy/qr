import base64

from Crypto.Cipher import AES
from Crypto.Util import Padding


def encode(password: str, content: str) -> str:
    cipher = AES.new(password.encode(), AES.MODE_ECB)
    bytes = cipher.encrypt(Padding.pad(content.encode(), 16))
    return base64.b64encode(bytes).decode()


def decode(password: str, content: str) -> str:
    cipher = AES.new(password.encode(), AES.MODE_ECB)
    bytes = cipher.decrypt(base64.b64decode(content))
    return Padding.unpad(bytes, 16).decode()
