import XCTest
@testable import vulcan_qr

final class vulcan_qrTests: XCTestCase {
    private let password = "0123456789ABCDEF"
    private let content = "CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT"
    private let base64 = Data(base64Encoded: "pDXpCcBDr7/wssR2YJpdaB+BXPJD5I28epToqZ1bO5O8qUTBru7NVAm9Rf3lDUr3RKAmoXKm5D96TnTI1yfUzQ==")!
    
    func testEncodeQR() throws {
        let result = try VulcanQR(password: password).encrypt(Data(content.utf8))
        XCTAssertEqual(base64, result)
    }
    
    func testDecodeQR() throws {
        let result = try VulcanQR(password: password).decryptToString(base64)
        XCTAssertEqual(content, result)
    }
}
