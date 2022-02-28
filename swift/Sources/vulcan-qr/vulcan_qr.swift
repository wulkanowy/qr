//
//  vulcan_qr.swift
//
//
//  Created by Tomasz on 13/02/2022.
//

import Foundation
import CryptoSwift

public class VulcanQR {
    let cipher: AES
    
    public init(password: String) throws {
        self.cipher = try AES(key: password.bytes, blockMode: ECB(), padding: .pkcs5)
    }
    
    public func decrypt(_ data: Data) -> Data? {
        if let result = try? cipher.decrypt(data.bytes) {
            return Data(result)
        }
        return nil
    }
    
    public func decryptToString(_ data: Data) -> String? {
        if let result = decrypt(data) {
            return String(data: result, encoding: .utf8)
        }
        return nil
    }
    
    public func encrypt(_ data: Data) -> Data? {
        if let result = try? cipher.encrypt(data.bytes) {
            return Data(result)
        }
        return nil
    }
}
