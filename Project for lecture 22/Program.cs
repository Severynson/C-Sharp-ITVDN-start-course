using System;

namespace Project_for_lecture_22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            uint minutesQuarter;


            Console.WriteLine("Enter please amount of minutes in calls in January: ");
            uint minutesJanuary = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Enter please amount of minutes in calls in February: ");
            uint minutesFebruary = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Enter please amount of minutes in calls in March: ");
            uint minutesMarch = Convert.ToUInt32(Console.ReadLine());
            
           // can past "uncheked block inside of checked block to
           // prevent of checking of some part"
            checked
            {
                minutesQuarter = minutesJanuary + minutesFebruary + minutesMarch;
            }

            decimal totalCost;
            {
                decimal price = 2;
                totalCost = price * minutesQuarter;
            }

            decimal tax;

            {
                decimal taxRate = 20; // %
                tax = totalCost / 100 * taxRate;
            }

            Console.WriteLine($"All:             {minutesQuarter} minutes");
            Console.WriteLine($"Total cost:      {totalCost} $");
            Console.WriteLine($"Tax              {tax} $");


            // delay
            Console.ReadKey();
        }
    }
}
 