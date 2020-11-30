namespace WulkanowyQr.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var encode = Qr.Encode("KEY", "CODE");
            var decode = Qr.Decode("KEY", "ENCRYPTED_CODE");
        }
    }
}