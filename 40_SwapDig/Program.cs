using System;
namespace Exercices
{
    class SwapDig
    {
        static void Main(string[]args)
        {
            //40.Write C# program to swap first and last digit of a number

            Console.WriteLine("Hello User! This is a program that swaps first and last digit of a number");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //convert to string
            string numb = num.ToString();
            //get the first digit
            char first  = numb[0];
            //get the last digit
            char last  = numb[numb.Length - 1];

            //print the last digit, then the rest of the nums in between, then the first digit
            Console.WriteLine($"\nAfter sawp = {last}{numb.Substring(1, numb.Length - 2)}{first}");

        }
    }
}
