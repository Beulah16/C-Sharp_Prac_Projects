using System;
namespace Practice
{
    class Multiply
    {
        static void Main(string[]args)
        {
            //4.C# Program to Multiply two Floating Point Numbers
            Console.WriteLine("Hello User! \nPlease input two floating point numbers");
            float a = Convert.ToSingle(Console.ReadLine());
            float b = Convert.ToSingle(Console.ReadLine());
        
            Console.WriteLine($"Product = {a * b}");
        }
    }
}