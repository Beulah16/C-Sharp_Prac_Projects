using System;
namespace Exercices
{
    class RevNum
    {
        static void Main(string[]args)
        {
            //44.Write C# program to reverse a number

            Console.WriteLine("Hello User! This is a program that reverses a number");
            Console.Write("Enter a number: ");
            
            int num =Convert.ToInt32(Console.ReadLine());
            Console.Write("\nReversed Number = ");
            while (num > 0)
            {
                int rm = num%10;
                num /= 10;
                Console.Write($"{rm}");
            }
        }
    }
}