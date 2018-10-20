package io.github.wulkanowy.qr

import org.junit.Assert.assertEquals
import org.junit.Test

class ConverterTest {

    private val password = "0123456789ABCDEF"

    private val content = "CERT#https://api.fakelog.cf/Default/mobile-api#FK100000#ENDCERT"

    private val base64 = "27Grk6d8ZDely5eeF7j2ngWrWV9eZa5Dz9ZmuiBavysDp74TCr6EHJOs6TaIXFh3HsROWSM11pv3cPvRGSi7Nw=="

    @Test
    fun decode() {
        assertEquals(content, decode(password, base64))
    }

    @Test
    fun encode() {
        assertEquals(base64, encode(password, content))
    }
}
