using System;
namespace Exercices
{
    class EvOd
    {
        static void Main(string[]args)
        {
            //15. C# Program to check whether an integer entered by the user is odd or even
            Console.Write("Hello User! \nEnter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 != 0)
            {
                Console.WriteLine($"{num} is an odd number");
            } else
            {
                 Console.WriteLine($"{num} is an even number");
            }
        }
    }
}