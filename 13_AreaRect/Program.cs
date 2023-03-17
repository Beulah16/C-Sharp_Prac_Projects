using System;
namespace Exercices
{
    class AreaRect
    {
        static void Main(string[]args)
        {
            //13. C# Program to Calculate Area of Rectangle

            Console.WriteLine("Hello User! \nEnter the values for the following parameters of a Rectangle:-");
            Console.Write("Length: ");
            var length = Convert.ToSingle(Console.ReadLine());
            Console.Write("Width: ");
            var width = Convert.ToSingle(Console.ReadLine());
            
            var area = length * width;
            Console.Write($"\nArea of the rectangle is: {area}");
        }
    }
}
