using System;
namespace Practice
    {
        class Swap
        {
            static void Main(string[]args)
            {
                //3.C# Program to Swap Values of Two Variables
                Console.WriteLine("Hello User! \nPlease input two values");
                Console.Write("val1 = ");
                var val1 = Convert.ToSingle(Console.ReadLine());
                Console.Write("val2 = ");
                var val2 = Convert.ToSingle(Console.ReadLine());

                var temp = val2;
                val2 = val1;
                val1 = temp;
                Console.WriteLine($"After Swap...val1 = {val1} and val2 = {val2}");            
            }
        }
    }