using System;
namespace Exercices
{
    class Factorial
    {
        static void Main(string[] args)
        {
            //46. Write C# program to find factorial of any number

            Console.WriteLine("Hello User! This is a program that finds the factorial of a number");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            //Factorial of a whole number 'n' is defined as the product of that number with every whole number less than or equal to 'n' till 1.
 
            for (int i = num; i > 0; i--)
            {
                if(i == num)
                {
                    continue;
                }
               num = num * i; 
            }
            Console.WriteLine($"The factorial of {temp} = {num}");
        }
    }
}
