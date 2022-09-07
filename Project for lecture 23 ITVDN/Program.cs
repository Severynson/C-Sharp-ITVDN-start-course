using System;

namespace Project_for_lecture_23_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            const double pi = 3.14;

            Console.WriteLine($"pi = {pi}");

            pi = 3.1415926535897;
            */

            /*
            const double pi = 3.14;
            double d = 3, l = pi * d;

            Console.WriteLine($"Length of the circle with diametr of {d} sm., equal to {l} sm.");
            */

            {
                // This will be enterpretiered as a mistake (casting operator necessary):

               // int constant = 255;
               // byte variable = constant;
               // Console.WriteLine(variable);
            }

            {
                const int constant = 255;
                byte variable = constant;
                Console.WriteLine(variable);
            }

            {
                const double constant = 255.99;
                byte variable = unchecked((byte)constant);
                Console.WriteLine(variable);
            }

            {
                const double constant = 256.0;
                byte variable = unchecked((byte)constant);
                Console.WriteLine(variable);
            }

            // Delay;
            Console.ReadKey();
        }
    }
}
