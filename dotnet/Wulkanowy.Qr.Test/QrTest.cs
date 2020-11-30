using Xunit;

namespace Wulkanowy.Qr.Test
{
    public class QrTest
    {
        private const string Password = "0123456789ABCDEF";
        private const string Content = "CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT";
        private const string Base64Content = "27Grk6d8ZDely5eeF7j2ngWrWV9eZa5Dz9ZmuiBavysDp74TCr6EHJOs6TaIXFh3HsROWSM11pv3cPvRGSi7Nw==";
        
        [Fact]
        public void EncodeQr()
        {
            var result = Qr.Encode(Password, Content);
            Assert.Equal(Base64Content, result);
        }

        [Fact]
        public void DecodeQr()
        {
            var result = Qr.Decode(Password, Base64Content);
            Assert.Equal(Content, result);
        }
    }
}