using System;
namespace Exercices
{
    class SumOd
    {
        static void Main(string[] args)
        {
            //39.Write C# program to find sum of odd numbers between 1 to n

            Console.WriteLine("Hello User! This is a program that prints sum of odd numbers between 1 to n");
            Console.Write("Enter a value for n: ");
            int num, sum;
            num = Convert.ToInt32(Console.ReadLine());
            sum = 0;

            for (int i = 1; i <= num; i++)
            {
                while (i % 2 != 0)
                {
                    sum += i;
                    i++;
                }
            }
            Console.WriteLine($"Sum of odd numbers = {sum}");
        }
    }
}