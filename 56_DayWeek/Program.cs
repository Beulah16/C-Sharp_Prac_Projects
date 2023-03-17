using System;
namespace Exercices
{
    class DayWeek
    {
        static void Main(string[] args)
        {
            //56.	Write C# program to print day of week name using switch case

                Console.WriteLine("Hello User! \nThis program prints day of week name");
                Console.Write("Enter Day Number: ");
                int daynum = Convert.ToInt32(Console.ReadLine());
                switch (daynum)
                {
                    case 1:
                        Console.Write(" ~Sunday");
                        break;
                    case 2:
                        Console.Write(" ~Monday");
                        break;
                    case 3:
                        Console.Write(" ~Tuesday");
                        break;
                    case 4:
                        Console.Write(" ~Wednesday");
                        break;
                    case 5:
                        Console.Write(" ~Thursday");
                        break;
                    case 6:
                        Console.Write(" ~Friday");
                        break;
                    case 7:
                        Console.Write(" ~Saturday");
                        break;
                }
                Console.WriteLine();
        }
    }
}
