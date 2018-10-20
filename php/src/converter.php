<?php

namespace Wulkanowy\UonetQRCodeConverter;

function decode(string $password, string $content): string
{
    $decoded = openssl_decrypt(
        base64_decode($content),
        'AES-128-ECB',
        $password,
        OPENSSL_RAW_DATA
    );

    if ($decoded === false) {
        throw new \RuntimeException(openssl_error_string());
    }

    return $decoded;
}

function encode(string $password, string $content): string
{
    $encoded = openssl_encrypt(
        $content,
        'AES-128-ECB',
        $password,
        OPENSSL_RAW_DATA
    );

    if ($encoded === false) {
        throw new \RuntimeException(openssl_error_string());
    }

    return base64_encode($encoded);
}
