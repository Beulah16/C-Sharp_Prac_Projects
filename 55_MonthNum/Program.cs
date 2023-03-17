using System;
namespace Exercices
{
    class MonthNum
    {
        static void Main(string[] args)
        {
            //55. Write C# program to print number of days in a month using switch case

                Console.WriteLine("Hello User! \nThis program prints the number of days in a month");
                Console.Write("Enter month: ");
                string month = Console.ReadLine();
                switch (month)
                {
                    case "January":
                        Console.Write(" =31 days");
                        break;
                    case "February":
                        Console.Write(" =28 days");
                        break;
                    case "March":
                        Console.Write(" =31 days");
                        break;
                    case "April":
                        Console.Write(" =30 days");
                        break;
                    case "May":
                        Console.Write(" =31 days");
                        break;
                    case "June":
                        Console.Write(" =30 days");
                        break;
                    case "July":
                        Console.Write(" =31 days");
                        break;
                    case "August":
                        Console.Write(" =31 days");
                        break;
                    case "September":
                        Console.Write(" =30 days");
                        break;
                    case "October":
                        Console.Write(" =31 days");
                        break;
                    case "November":
                        Console.Write(" =30 days");
                        break;
                    case "December":
                        Console.Write(" =31 days");
                        break;
                }
            Console.WriteLine();
        }
    }
}
