using System;

namespace Project_for_lecture_29_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 1, b = 2, max;

            if (a > b) max = a; else max = b;

            Console.WriteLine(max);

            max = 0;

            max = a > b ? a : b;

            Console.WriteLine(max);

            //

            int value = 1;
            ref int refForValue = ref value;

            Console.WriteLine($"refForValue = {refForValue}");
            refForValue += 2;
            Console.WriteLine($"after refForValue += 2, value = {value}");
            value--;
            Console.WriteLine($"refForValue = {refForValue} after value --");
        }
    }
}
