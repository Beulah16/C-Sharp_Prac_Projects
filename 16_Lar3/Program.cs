using System;
namespace Exercices
{
    class Lar3
    {
        static void Main(string[] args)
        {
            //16. C# Program to find the largest number among three number.

            int num1, num2, num3;
            Console.WriteLine("Hello User! \nEnter 3 numbers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine()); 
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} is the largest number");
            } else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} is the largest number");
            }  else
            {
                Console.WriteLine($"{num3} is the largest number");
            }
        }
    }
}
