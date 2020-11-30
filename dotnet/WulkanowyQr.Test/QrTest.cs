using System;
using Xunit;

namespace Wulkanowy.Test
{
    public class QrTest
    {
        private const string _password = "0123456789ABCDEF";
        private const string _content = "CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT";
        private const string _base64Content = "27Grk6d8ZDely5eeF7j2ngWrWV9eZa5Dz9ZmuiBavysDp74TCr6EHJOs6TaIXFh3HsROWSM11pv3cPvRGSi7Nw==";
        
        [Fact]
        public void EncodeQr()
        {
            string result = Qr.Encode(_password, _content);
            Assert.Equal(_base64Content, result);
        }

        [Fact]
        public void DecodeQr()
        {
            string result = Qr.Decode(_password, _base64Content);
            Assert.Equal(_content, result);
        }
    }
}