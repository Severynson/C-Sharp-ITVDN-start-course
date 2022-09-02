using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_lecture_19_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*

            // Weak   tipisation example:

            dynamic variable = 2;

            Console.WriteLine(variable);

            variable = "Hello";

            Console.WriteLine(variable);

            */

            // Strong tipisation but type defined automatically;

            // var != dynamic;
            var variable = "Hello world!";
            variable = 123;

            Console.WriteLine(variable);

        }
    }
}
