using System;
namespace Exercices
{
    class NaturalNumRev
    {
        static void Main(string[] args)
        {
            //36.Write C# program to print all natural numbers in reverse order

            Console.WriteLine("Hello User! This is a program that prints all natural numbers in reverse order");
            Console.Write("Enter a natural number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine($"{0}.");
        }
    }
}