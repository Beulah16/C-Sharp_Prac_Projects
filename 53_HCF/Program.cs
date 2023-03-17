using System;
namespace Exercices
{
    class NumWords
    {
        static void Main(string[] args)
        {
            //53. Write C# program to find HCF of two numbers
            Console.WriteLine("Hello User! \nThis program finds HCF of two numbers");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int min = Math.Min(num1, num2);
            int hcf = 1;
            for(int i = 1; i <= min; i++)
            {
                if (num1%i == 0 && num2%i == 0)
                {
                    hcf = i;
                }
            }
            Console.Write($"HCF = {hcf}");
        }
    }
}
