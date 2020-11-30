using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Wulkanowy
{
    //See https://docs.microsoft.com/en-gb/dotnet/api/system.security.cryptography.aes?view=net-5.0
    
    public class Qr
    {
        public static string Encode(string key, string content)
        {
            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                var enc = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(memoryStream, enc, CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(csEncrypt))
                        {
                            writer.Write(content);
                        }

                        encrypted = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }

        public static string Decode(string key, string content)
        {
            string decrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                var dec = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(content)))
                {
                    using (CryptoStream cs = new CryptoStream(memoryStream, dec, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            decrypted = reader.ReadToEnd();
                        }
                    }
                }
            }
            return decrypted;
        }
    }
}