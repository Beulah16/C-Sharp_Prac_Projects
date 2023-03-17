using System;
namespace Exercices
{
    class AnsciiLoop
    {
        static void Main(string[] args)
        {
            //34.Write C# program to print ASCII values of all characters

            Console.WriteLine("Hello User! This is a program that prints ASCII values of all characters\n");

            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine($"ANSCII value of {Convert.ToChar(i)}: {i}");
            }
        }
    }
}