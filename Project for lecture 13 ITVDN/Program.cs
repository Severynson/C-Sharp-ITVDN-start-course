using System;

namespace Project_for_lecture_13_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*

            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello world!");

            Console.ForegroundColor++;
            Console.WriteLine("Hello world!");

            ++ Console.ForegroundColor;
            Console.WriteLine("Hello world!");

            Console.ForegroundColor++;
            Console.WriteLine("Hello world!");

            */

            /*

            Console.WriteLine(2 + double.NaN);

            Console.WriteLine(-0d / +0d);

            Console.WriteLine(double.NegativeInfinity / double.PositiveInfinity);

            Console.WriteLine(0 * double.PositiveInfinity);

            Console.WriteLine(double.NegativeInfinity + double.PositiveInfinity);

            Console.WriteLine(Math.Pow(6, 2));

            Console.WriteLine(Math.Sqrt(-36));

            Console.WriteLine(Math.Log(-36, 6));

            */

            // Postfix operators are the most low priority
            // in the compilator's stack of tasks;

            int a = 0, b = a++ * 5;
            Console.WriteLine($"a = {a}, b = {b}");

            // Prefix operators are the highest priority
            // in the compilator's stack of tasks;

            int e = 0, f = ++e * 5;
            Console.WriteLine($"e = {e}, f = {f}");

            // Do you think you saw all "FeAtUrEs" already?

            // :)

            // Nooo... There are some specific exceptions
            // When the postfix operators can behave realy strange;

            // I mean... More specific than you saw already;

            int c = 0, d = (c++ * 5) + c; // as you see...
            // Brackets will not change the priority in this situation;
            // It's not a bug, it's FeAtUrE :)
            Console.WriteLine($"c = {c}, d = {d}");

        }
    }
}
