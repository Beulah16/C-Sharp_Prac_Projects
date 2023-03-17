using System;
namespace Exercices
{
    class Power
    {
        static void Main(string[] args)
        {
            //45. Write C# program to calculate power using while & for loop

            Console.WriteLine("Hello User! This is a program that calculates power of a number");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the power to which the number would be raised: ");
            int exp = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            
            for (int i = 1; i < exp; i++)
            {
                num = num * temp;
            }
            Console.WriteLine($"\n{temp} raised to power of {exp} = {num}");

            //----------OR---------------
            //Console.WriteLine($"\n{num} raised to {exp} = {Math.Pow(num, exp)}");
        }
    }
}
