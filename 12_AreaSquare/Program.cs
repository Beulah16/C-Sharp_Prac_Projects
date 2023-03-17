using System;
namespace Exercices
{
    class AreaSquare
    {
        static void Main(string[]args)
        {
            //12. C# Program to Calculate Area of Square

            Console.WriteLine("Hello User! \nEnter the values for the following parameters of a square:-");
            Console.Write("Length: ");
            var length = Convert.ToSingle(Console.ReadLine());

            float area = length * length;
            Console.Write($"\nArea of the square is: {area}");
        }
    }
}