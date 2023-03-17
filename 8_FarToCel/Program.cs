using System;
namespace Exercices
{
    class FarToCel
    {
        static void Main(string[] args)
        {
            //8. C# Program to convert farenheit to celcius

            Console.WriteLine("Hello User! \nPlease input a unit in fahrenheit");
            var num = Convert.ToSingle(Console.ReadLine());


            var conv = (num - 32) * 1.8;
            Console.WriteLine($"Value in celcius = {conv}C");
        }
    }
}