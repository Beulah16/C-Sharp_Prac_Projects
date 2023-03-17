using System;
namespace Exercices
{
    class MonthDays
    {
        static void Main(string[]args)
        {
            //30.C# program to enter month number and print number of days in month.

            Console.WriteLine("Hello User! This program prints number of days in month.\nPlease pick a month number(from 1-12)");
            int mnth = Convert.ToInt32(Console.ReadLine());

            /*1.Jan = 31 days
             *2.Feb = 28 days
             *3.Mar = 31 days
             *4.Apr = 30 days
             *5.May = 31 days
             *6.Jun = 30 days
             *7.Jul = 31 days
             *8.Aug = 31 days
             *9.Sep = 30 days
             *10.Oct = 31 days
             *11.Nov = 30 days
             *12.Dec = 31 days*/
            if (mnth == 1||mnth == 3||mnth == 5||mnth == 7||mnth == 8||mnth == 10||mnth == 12)
            {
                Console.WriteLine("31 days");
            } else if(mnth == 4||mnth == 6||mnth == 9||mnth == 11)
            {
                Console.WriteLine("30 days");
            } else if(mnth == 2)
            {
                Console.WriteLine("28 days");
            } else
            {
                Console.WriteLine("Invalid Month Number");
            }
        }
    }
}