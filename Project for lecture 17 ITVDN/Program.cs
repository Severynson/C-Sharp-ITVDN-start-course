using System;

namespace Project_for_lecture_17_ITVDN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            Console.WriteLine(!true);
            Console.WriteLine(!false);

            bool imSittingOnTheMars = false;
            bool imWatchingCSharpCourse = true;
            bool imSitting = true;

            Console.WriteLine(imWatchingCSharpCourse & imSittingOnTheMars);
            Console.WriteLine(imWatchingCSharpCourse & imSitting);
            Console.WriteLine(imWatchingCSharpCourse);
            Console.WriteLine(imSitting);
            Console.WriteLine(imSittingOnTheMars);

            */

            /*

            bool x = true, y = true, result = x & y;
            Console.WriteLine($"1. {x,-5} & {y,-5} = {result,-5}");

            x = y = false;
            Console.WriteLine($"2. {x,-5} & {y,-5} = {x & y,-5}");

            result = (x = true) & y;
            Console.WriteLine($"3. {x,-5} & {y,-5} = {result,-5}");

            (x, y) = (y, x);
            Console.WriteLine($"4. {x,-5} & {y,-5} = {x & y,-5}");
        
            */

            /*

            Console.WriteLine("Pass the age of the client:");
            int clientAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pass the salary of the client:");
            int clientSalary = Convert.ToInt32(Console.ReadLine());

            // Demands for getting bank's credit:
            // 1. Age from 21 to 55 years old ;
            // 2. Salary not less than 1500$  ;

            int minSalary = 1500, minAge = 21, maxAge = 55;
            
            bool isBankLoanAllowed = clientSalary >= minSalary & clientAge >= minAge & clientAge <= maxAge;
            Console.WriteLine($"Bank loan allowed status: {isBankLoanAllowed}");

            */

            /*

            Console.WriteLine("Pass the age of the client:");
            int clientAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pass the salary of the client:");
            int clientSalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Client has guarantor ( yes / no ):");
            bool hasGuarantor = Console.ReadLine() == "yes";
            bool hasCollateralSecure;
            if (!hasGuarantor)
            {
                Console.WriteLine("Presence of finance vouch ( yes / no ):");
                hasCollateralSecure = Console.ReadLine().Contains("yes");
            }
            else
            {
                hasCollateralSecure = false; //"Not important, first fact enough";
            };


            // New demands:
            // 1. Age from 21 to 55 years old and Salary not less than 1500$;
            // 2. Or If has guarantor or has collateral secure;

            int minSalary = 1500, minAge = 21, maxAge = 55;

            bool isBankLoanAllowed
            = clientSalary >= minSalary
            & clientAge >= minAge
            & clientAge <= maxAge
            | hasGuarantor | hasCollateralSecure;

            Console.WriteLine($"Bank loan allowed status: {isBankLoanAllowed}");

            */

            Console.WriteLine("Secondname of subsidy caller:");
            string secondName = Console.ReadLine();

            Console.WriteLine($"Is {secondName} pensioner? :");
            bool isPensioner = Console.ReadLine().Contains("yes");

            Console.WriteLine($"Is {secondName} standing on the " +
                $"accounting in the employment service? :");
            bool isUnemployed = Console.ReadLine().Contains("yes");

            Console.WriteLine($"{secondName} has a job? :");
            bool isEmployment = Console.ReadLine().Contains("yes");

            bool subsidyAllowed = isPensioner ^ (isUnemployed && isEmployment);

            Console.WriteLine($"{secondName} has right for subsidy: {subsidyAllowed}");
        }

    }
}
