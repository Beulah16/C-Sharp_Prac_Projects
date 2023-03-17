using System;
namespace Exercices
{
    class FeToMe
    {
        static void Main(string[]args)
        {
            //6. C# Program to convert feet to meter

            Console.WriteLine("Hello User! \nPlease input a unit in feet");
            var num = Convert.ToSingle(Console.ReadLine());

            var meter = 0.3048;
            var conv = num * meter;
            Console.WriteLine($"Value in meters = {conv}m");
        }
    }
}
