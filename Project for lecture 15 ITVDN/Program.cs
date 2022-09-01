using System;

namespace Project_for_lecture_15_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*

            string firstPart = "Hello", secondPart = "world";

            string text = firstPart + " " + secondPart;

            text += "!";

            Console.WriteLine(text);

            */

            /*

            Console.WriteLine("Write the augend:");
            string stringAugend = Console.ReadLine();

            Console.WriteLine("Write the addend:");
            string stringAddend = Console.ReadLine();

            int augend = Convert.ToInt32(stringAugend);
            int addend = Convert.ToInt32(stringAddend);

            int sum = augend + addend;

            // string result = augend + " + " + addend + " = " + sum;

            // Console.WriteLine(result);

            string result = string.Format("Result: {0} + {1} = {2}", augend, addend, sum);

            Console.WriteLine(result);

            */

            /*

            Console.WriteLine("   format: {0}", 0.123456789_12345678);
            // R formater used for more accurate result:
            Console.WriteLine("R  format: {0:R}", 0.123456789_12345678);
            
            */

            double interpolationExpression = 0.123456789_12345678;

            Console.WriteLine("");

            // Delay
            Console.ReadKey();

        }
    }
}
