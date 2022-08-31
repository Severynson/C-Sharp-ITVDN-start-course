using System;

namespace Project_for_lecture_11_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int sizeOfDecimal = sizeof(decimal);
            // Int32 sizeOfByte = sizeof(byte);
            //
            // Console.WriteLine(sizeOfDecimal);
            // Console.WriteLine(sizeOfByte);

            ////////////////////////////////////////

            // int negativeNumber = -1;          // 11111111 11111111 11111111 11111111
            // uint naturalNumber = 4294967295;  // 11111111 11111111 11111111 11111111

            // Console.WriteLine(negativeNumber);
            // Console.WriteLine(naturalNumber);

            // // Check of variables meaning in binary representation:

            // Console.WriteLine(Convert.ToString(negativeNumber, 2));
            // Console.WriteLine(Convert.ToString(naturalNumber, 2));

            /////////////////////////////////////////

            // // implicit casting:
            // byte valueOfLowerType = 255;
            // int valueOfGreaterType = valueOfLowerType;

            // Console.WriteLine(valueOfLowerType);
            // Console.WriteLine(valueOfGreaterType);

            /*
            int valueOfGreaterType = 256;
            byte valueOfLowerType = (byte)valueOfGreaterType;

            // max of byte is 255 ( 0 including too );
            // So we loosing all the first part and we dont have any
            // remainder left what = 0 after converting to byte;

            Console.WriteLine(valueOfGreaterType);
            Console.WriteLine(valueOfLowerType);

            */

            /*
            float pi = 3.14f;

            Console.WriteLine(pi);
            */

            /*
            int a = 259; // max of byte is 255 ( 0 including too );

            // During casting we are loosing first part of number
            // in bynary representation and getting just last part
            // of number.



            byte b = (byte)a;

            // Maximum for int was 256. So during converting
            // we are loosing 256 (because it was placed in the
            // first byte of memory which was cut by datatype
            // casting. So - just 3 left (because 259 - 256) );

            Console.WriteLine(b);

           */

            // delay:
            Console.ReadKey();
        }
    }
}
