using System;

namespace Project_for_lecture_29_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                int a = 1, b = 2, max;

                if (a > b) max = a; else max = b;

                Console.WriteLine(max);

                max = 0;

                max = a > b ? a : b;

                Console.WriteLine(max);
            }


            //

            {
                int value = 1;
                ref int refForValue = ref value;

                Console.WriteLine($"refForValue = {refForValue}");
                refForValue += 2;
                Console.WriteLine($"after refForValue += 2, value = {value}");
                value--;
                Console.WriteLine($"refForValue = {refForValue} after value --");
            }



            {
                byte b = 22;
                ref readonly byte a = ref b;
                Console.WriteLine("a = " + a + " but changing a with crash compiling process.\nWhy?\nBecause a is readonly insead of b");
            }

            {
                // Will be mistake here. Ref can't linking to const:

                //  const int g = 33;
                //  ref int a = ref g;
                //  Console.WriteLine(a);
            }

            {
                byte x = 3;
                ref byte y = ref x, z = ref y;
                z = 11;
                z += 1;
                Console.WriteLine($"x = {x}, y = {y}, z = {z};");
            }

        }
    }
}
