<?php

use PHPUnit\Framework\TestCase;
use function Wulkanowy\UonetQRCodeConverter\decode;
use function Wulkanowy\UonetQRCodeConverter\encode;

class ConverterTest extends TestCase
{
    private $password = '0123456789ABCDEF';
    private $content = 'CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT';
    private $base64 = '27Grk6d8ZDely5eeF7j2ngWrWV9eZa5Dz9ZmuiBavysDp74TCr6EHJOs6TaIXFh3HsROWSM11pv3cPvRGSi7Nw==';

    public function testDecode()
    {
        $this->assertEquals($this->content, decode($this->password, $this->base64));
    }

    public function testEncode()
    {
        $this->assertEquals($this->base64,  encode($this->password, $this->content));
    }
}
