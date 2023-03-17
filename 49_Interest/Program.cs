using System;
namespace Exercices
{
    class Interest
    {
        static void Main(string[]args)
        {
            //49.Write C# program to calculate compound Interest

            Console.WriteLine("Hello User! This is a program that calculates compound Interest");
            Console.WriteLine("Enter the values for the following; ");
            Console.Write("Principal: ");
            float p = Convert.ToInt32(Console.ReadLine());
            float temp = p;
            Console.Write("Rate: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Time(in years): ");
            int t = Convert.ToInt32(Console.ReadLine());
            float Interest;
            float amt = 0;
            Interest = (p*r*1)/100;
            amt =temp + Interest;
            
            for (int i = 1; i < t; i++)
            {
                p = amt;
                Interest = (p*r*1)/100;
                amt += Interest;
            }
           
            float CompIn = amt - temp;
            
            Console.WriteLine($"Compound Interest = {CompIn}");
        }
    }
}