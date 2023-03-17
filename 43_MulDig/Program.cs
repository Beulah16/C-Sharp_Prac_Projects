using System;
namespace Exercices
{
    class MulDig
    {
        static void Main(string[]args)
        {
            //43.Write C# program to calculate product of digits of a number

            Console.WriteLine("Hello User! This is a program that calculates product of digits of a number");
            Console.Write("Enter a number: ");
            
            int num =Convert.ToInt32(Console.ReadLine());
            int prod = 1;
            while (num > 0)
            {
                int rm = num%10;
                num /= 10;
                prod *= rm;
            }
            Console.WriteLine($"\nProduct of the digits of this number = {prod}");
        }
    }
}