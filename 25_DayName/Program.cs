using System;
namespace Exercices
{
    class DayName
    {
        static void Main(string[] args)
        {
            //25. C# program to print day name of week.
           
            int day;
            Console.Write("Hello User \nEnter a day number in a week (from 1-7): ");
            day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                 case 1:
                Console.WriteLine("Sunday");
                break;
                case 2:
                Console.WriteLine("Monday");
                break;
                case 3:
                Console.WriteLine("Tuesday");
                break;
                case 4:
                Console.WriteLine("Wednesday");
                break;
                case 5:
                Console.WriteLine("Thursday");
                break;
                case 6:
                Console.WriteLine("Friday");
                break;
                case 7:
                Console.WriteLine("Saturday");
                break;
                default:
                Console.WriteLine("Invalid day number");
                break;
            }
        }
    }
}