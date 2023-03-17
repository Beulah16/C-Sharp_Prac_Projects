using System;
namespace Exercices
{
    class AreaCircle
    {
        static void Main(string[]args)
        {
            //11. C# Program to Calculate Area of Circle

            Console.WriteLine("Hello User! \nEnter the values for the following parameters of a circle:-");
            Console.Write("Radius: ");
            var radius = Convert.ToSingle(Console.ReadLine());
            
            var area = Convert.ToSingle(Math.PI) * (radius * radius);
            Console.Write($"\nArea of the circle is: {area}");
        }
    }
}