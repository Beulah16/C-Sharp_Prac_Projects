using System;
namespace Practice
{
    class Add
    {
        static void Main(string[]args)
        {
            //2.C# Program to Add Two Integers.
            Console.WriteLine("Hello User! \nPlease input two integers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum = {a+b}");
        }
    }
}