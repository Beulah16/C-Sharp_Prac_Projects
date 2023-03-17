using System;
namespace Exercices
{
    class CelToFar
    {
        static void Main(string[] args)
        {
            //7. C# Program to convert celcius to farenheit

            Console.WriteLine("Hello User! \nPlease input a unit in celcius");
            var num = Convert.ToSingle(Console.ReadLine());

            
            var conv = (num * 1.8) + 32;
            Console.WriteLine($"Value in fahrenheit = {conv}F");
        }
    }
}
