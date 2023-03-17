using System;
namespace Exercices
{
    class Triangle
    {
        static void Main(string[]args)
        {

            //32.C# program to check whether a triangle can be formed by the given value for the angles.

            Console.WriteLine("Hello User! This program checks whether a triangle can be formed by the given value for the angles.");
            Console.Write("\nEnter value for the angles. \nAngle a = ");
            var a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Angle b = ");
            var b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Angle c = ");
            var c = Convert.ToSingle(Console.ReadLine());

            if (a+b+c == 180)
            {
                Console.WriteLine("A Triangle can be formed");
            } else
            {
                Console.WriteLine("A Triangle cannot be formed");
            }
        }
    }
}
