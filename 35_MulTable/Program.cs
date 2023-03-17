using System;
namespace Exercices
{
    class MulTable
    {
        static void Main(string[] args)
        {
            //35.Write C# program to print multiplication table of a given number

            Console.WriteLine("Hello User! This is a program that prints multiplication table of a number");
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }
        }
    }
}
