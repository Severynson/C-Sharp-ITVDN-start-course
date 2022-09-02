using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_lecture_20_ITVDN
{
    internal class Program
    {

        static int field = 3; // field of class; ( Wrongly can be called global variables )

        static void Main(string[] args)
        {

            /*

            {
                float t = 22.5f; // C degreece;
                Console.WriteLine($"temperature = {t}");
            }

            {
                float t = 11.35f; // time per minute;
                Console.WriteLine($"time = {t}");
            }

            */

            /*

            {
                // Will be a mistake here;
                //int variable = 4;
                //Console.WriteLine(variable);
            }

            int variable = 5;
            Console.WriteLine(variable);
        
            */

            int localVariable = 4;

            {
                int localLocalVariable = 5;
                Console.WriteLine(field);
            }

            }
    }
}
