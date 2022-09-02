using System;

namespace Project_for_lecture_18_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*

            int a = 1;
            int b = ~a;
            // inverted x + 1 = -x
            int c = b + 1;

            Console.WriteLine($"a = {a}, b = {b}, c = {c};");

            */

            /*

            byte port = 0b_0000_1111; // 0F Hex = 15 Dec
            Console.WriteLine($"port = {port:X2} = {port}");

            byte mask = 0b_1111_1011; // FB Hex = 251 Dec;
            Console.WriteLine($"mask = {mask:X2} = {mask}");

            port = (byte)(port & mask); // 0B Hex = 11 Dec;
            Console.WriteLine($"port = {port:X2} = {port}");

            mask = 0b_0000_0100; // 4 Hex = 4 Dec;
            Console.WriteLine($"mask = {mask:X2} = {mask}");

            port = (byte)(port | mask);
            Console.WriteLine($"port = {port:X2} = {port}");
        
            */

            char originalValue = 'A';
            Console.WriteLine($"OriginalValue = {originalValue}");

            ushort key = 55;
            Console.WriteLine($"key = {key}");

            char encryptedValue = (char)(originalValue ^ key);
            Console.WriteLine($"encryptedValue = {encryptedValue}");

            char decryptedValue = (char)(encryptedValue ^ key);
            Console.WriteLine($"decryptedValue = {decryptedValue}");

            byte someByteNumber = 0b_0001_0000;
            Console.WriteLine("To get know what is 4th bit position (1/2) we need:" +
                "\n ourByte << (position of bit in byte to check counted from the end" +
                "\n of byte) >> 7. This way we are moving bit that interests us to the" +
                "\n 1st position");

            Console.WriteLine(someByteNumber << 3 >> 7);

        }
    }
}
