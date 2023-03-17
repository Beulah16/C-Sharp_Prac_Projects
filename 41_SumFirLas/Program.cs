using System;
namespace Exercices
{
    class SumFirLas
    {
        static void Main(string[] args)
        {
            //41.Write C# program to find the sum of first and last digit of any number

            Console.WriteLine("Hello User! This is a program that sums the first and last digit of any number");
            Console.Write("Enter a number: ");
            
            int num = Convert.ToInt32(Console.ReadLine());
            int last = num % 10;
            while (num >= 10)
            {
                num /= 10;
            }
            int first = num;
            Console.WriteLine($"\nSum of first and last digit = {first + last}");
        }
    }
}