using System;
namespace Exercices
{
    class PrimeNum
    {
        static void Main(string[] args)
        {
            //50.Write C# program to check if an entered number is Prime number or not using while & for loop

            Console.WriteLine("Hello User! This is a program that checks if a number is a Prime number or not ");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //A Prime number is a number that can only be divided by one and itself
            int chk = 0;

            for (int i = 1; i <= num; i++)
            {
                    if(num%i == 0)
                    {
                        chk++;
                    }  
            }
            if (chk == 2) 
            {
                Console.WriteLine($"{num} is a Prime Number");
            } 
            else 
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}