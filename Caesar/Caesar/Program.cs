using System;
using Caesar.Core;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            var proc = new CaesarCipherProcessor();
            var input = "ABCDEF";
            Console.WriteLine($"encrypted: {proc.Encrypt(input, 2)}");
        }
    }
}
