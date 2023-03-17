using System;
namespace Exercices
{
    class SumEv
    {
        static void Main(string[] args)
        {
            //38.Write C# program to find sum of even numbers between 1 to n

            Console.WriteLine("Hello User! This is a program that prints sum of even numbers between 1 to n");
            Console.Write("Enter a value for n: ");
            int num, sum;
            num = Convert.ToInt32(Console.ReadLine());
            sum = 0;

            for(int i = 2; i <= num; i=i+2)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of even numbers = {sum}");
        }
    }
}