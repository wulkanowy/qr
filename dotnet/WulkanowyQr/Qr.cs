using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace WulkanowyQr
{
    //See https://docs.microsoft.com/en-gb/dotnet/api/system.security.cryptography.aes?view=net-5.0
    
    public class Qr
    {
        public static string Encode(string key, string content)
        {
            using var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;

            var enc = aes.CreateEncryptor(aes.Key, aes.IV);

            using var memoryStream = new MemoryStream();
            using var csEncrypt = new CryptoStream(memoryStream, enc, CryptoStreamMode.Write);
            using (var writer = new StreamWriter(csEncrypt))
            {
                writer.Write(content);
            }

            var encrypted = memoryStream.ToArray();

            return Convert.ToBase64String(encrypted);
        }

        public static string Decode(string key, string content)
        {
            using var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;

            var dec = aes.CreateDecryptor(aes.Key, aes.IV);

            using var memoryStream = new MemoryStream(Convert.FromBase64String(content));
            using var cs = new CryptoStream(memoryStream, dec, CryptoStreamMode.Read);
            using var reader = new StreamReader(cs);

            return reader.ReadToEnd();
        }
    }
}