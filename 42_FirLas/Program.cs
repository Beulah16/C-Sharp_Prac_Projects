using System;
namespace Exercices
{
    class FirLas
    {
        static void Main(string[] args)
        {
            //42.Write C# program to find first and last digit of any number

            Console.WriteLine("Hello User! This is a program that finds the first and last digit of any number");
            Console.Write("Enter a number: ");
            
            int num = Convert.ToInt32(Console.ReadLine());
            int last = num % 10;
            while (num >= 10)
            {
                num /= 10;
            }
            int first = num;
            Console.WriteLine($"\nFirst digit = {first} \nLast digit = {last}");

            //              OR
            /*string numb = num.ToString();
            char first  = numb[0]
            char last  = numb[numb.Length - 1];
            Console.WriteLine($"\nFirst digit = {first} \nLast digit = {last}");*/

        }
    }
}