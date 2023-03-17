using System;

namespace Exercices
{
    class LeapYr
    {
        static void Main(string[] args)
        {
            //19. C# program to check leap year using conditional Operator.
            int year;
            Console.WriteLine("Hello User! \nEnter Year");
            year = Convert.ToInt32(Console.ReadLine());
            
            //Any year that is evenly divisible by 4 is a leap year
            Console.WriteLine(year % 4 == 0 ? $"The year {year} is a leap year" : $"The year {year} is not a leap year");
        }
    }
}
