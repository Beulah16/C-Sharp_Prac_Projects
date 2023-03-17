using System;
namespace Exercices
{
    class NumWords
    {
        static void Main(string[] args)
        {
            //54.Write C# program to find LCM of two numbers
            Console.WriteLine("Hello User! \nThis program finds LCM of two numbers");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int x = num1;
            int y = num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            int lcm = (x * y) / num1;
            Console.Write("LCM = " + lcm);
        }
    }
}
