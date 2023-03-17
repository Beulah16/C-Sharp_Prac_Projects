using System;
namespace Exercices
{
    class LarCon
    {
        static void Main(string[] args)
        {
            //17. C# Program to Find the Largest Number using Conditional Operator.

            int num1, num2, num3, largest;
            Console.WriteLine("Hello User! \nEnter 3 numbers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            largest = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            Console.WriteLine($"{largest} is the largest number");
        }
    }
}
