using System;
namespace Exercices
{
    class DaysConv
    {
        static void Main(string[] args)
        {
            //14. C# Program to convert days to years, weeks, hours, minutes and seconds

            int days, years, weeks, hours, minutes, seconds;
            Console.Write("Hello User! \nEnter a number of days: ");
            days = Convert.ToInt32(Console.ReadLine());

            //365 days make a year
            years = days / 365;
            //7 days make a week
            weeks = days / 7;
            //24 hours make a day
            hours = days * 24;
            //60 minutes make an hour
            int daymin = 60 * 24;// =minutes in one day
            minutes = days * daymin;
            //60 seconds make a minute
            int daysec = 60 * daymin;// =seconds in one day
            seconds = days * daysec;
            
            Console.WriteLine($"{days} days is equvalent to: "); 
            Console.WriteLine($"{years} years");
            Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
            Console.WriteLine($"{seconds} seconds");
        }
    }
}