using System;

namespace Project_for_lecture_12_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte augend = 1, addend = 2;
            // int sum = augend + addend; // Addition

            //

            /*

            byte augend = 1, addend = 2;
            byte sum = (byte)(augend + addend); // Addition

            byte minuend = 5, subtrahend = 3;
            int difference = minuend - subtrahend; // Subtraction

            byte multiplicand = 2, multiplier = 3;
            int product = multiplicand * multiplier; // Multiplication

            byte dividen = 1, divisor = 2;
            int quotient = dividen / divisor;  // Division (finding quotient)
            int remainder = dividen % divisor; // Division (finding remainder)

            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
            Console.WriteLine("Result of dividing: " + quotient + '.' + remainder);

            */

            /*

            byte apples = 16;
            byte pears = 16;

            byte fruits = (byte)(apples + pears);

            Console.WriteLine(fruits);

            */

            float T_mo = 3, T_tu = -2, T_we = -5, T_th = 3, T_fr = 1, T_sa = 4, T_su = -3;
            float T_sum = T_mo + T_tu + T_we + T_th + T_fr + T_sa + T_su;
            int daysInWeek = 7;



            // // Example of the bad code with magic numbers:
            // float T_avg = ( + (-2f) + (-5f) + 3f + 1f + 4f + (-3f)) / 7;

            float T_avg = T_sum / daysInWeek;

            Console.WriteLine(T_avg);

            // delay
            Console.ReadKey();
        }
    }
}
