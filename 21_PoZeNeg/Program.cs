using System;
namespace Exercices
{
    class PoZeNeg
    {
        static void Main(string[] args)
        {
            //21. C# program to check number is positive, negative or zero.

            int num;
            Console.Write("Hello User! \nEnter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine("This is a positive number");
            } else if(num < 0)
            {
                Console.WriteLine("This is a negative number");
            }  else
            {
                Console.WriteLine($"This number is Zero");
            }
        }
    }
}
