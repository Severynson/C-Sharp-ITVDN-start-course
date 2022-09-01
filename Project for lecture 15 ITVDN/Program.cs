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

            /*
            
            double interpolationExpression = 0.123456789_12345678;
            const int alignment = 30;

            Console.WriteLine($"8. R format: {interpolationExpression,-alignment:R} : End."); // Round-Trip

            Console.WriteLine($"8. R format: {interpolationExpression,alignment:R} : End."); // Round-Trip

            */

            Console.WriteLine("Severyn says: \"Hello\".");
            Console.WriteLine(@"Severyn says: ""Hello"".");
            Console.WriteLine("Hello world!\0");

            Console.WriteLine("Do you like this sound?\a :D");
            Console.Write("Do you like this sound?\b");
            Console.WriteLine("(\"?\" sign was replaced by all this)");

            Console.WriteLine("Hello\fBuy"); // Next page command for printers;

            Console.WriteLine("Hello\n");

            // Console.Write("Hello\r");

            Console.WriteLine("Enter please smthg new: \n\r(smthng new)");
            // string somethingNew = Console.ReadLine();
            // Console.WriteLine($"Here is smthng new: {somethingNew}");

            Console.WriteLine("\t1\t2\t3");

            Console.WriteLine("\v1\v2\v3"); // Tabulation just for printer;


            // We can format unicode for console with backslash:
            Console.WriteLine(/*Letter's code starts with U*/
                "\u0048\u0065\u006c\u006c\u006f" +
                /*Space simbol: */  "\u0020" +
                /* ASCII simbols  */ "\n \"H\" letter in ASCII: \x48" +
                /* Smile: */ "\nSmile: \u0002"
                );

            // Backslash will convert unicode in char format to numbers instead of concatination:
            Console.WriteLine($"{Convert.ToInt32('\u0048')} + {Convert.ToInt32('\u0065')} = { '\u0048' + '\u0065'}");

            // Delay
            Console.ReadKey();
        }
    }
}
