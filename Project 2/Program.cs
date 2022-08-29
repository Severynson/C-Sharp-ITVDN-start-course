using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Turn the sound on.\n1, 2, 3...");
            Console.Beep(392, 500);  // Соль
            Console.Beep(440, 500);  // Ля
            Console.Beep(494, 800);  // Сі
            Console.Beep(392, 500);  // Соль
            Console.Beep(440, 500);  // Ля
            Console.Beep(523, 700);  // До
            Console.Beep(494, 900);  // Сі
            Console.Beep(392, 500);  // Соль
            Console.Beep(440, 500);  // Ля
            Console.Beep(494, 800);  // Сі
            Console.Beep(440, 500);  // Ля
            Console.Beep(392, 1200); // Соль
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nSmoke on the water cover by Severyn");
            Console.Read();
        }
    }
}
