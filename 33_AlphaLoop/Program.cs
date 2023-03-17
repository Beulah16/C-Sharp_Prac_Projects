using System;
namespace Exercices
{
    class AlphaLoop
    {
        static void Main(string[]args)
        {
            //33.Write C# program to print alphabets from a to z
            Console.WriteLine("Hello User! This is a program that prints alphabets from a to z \n");

            for(char ä = 'a'; ä <='z'; ä++)
            {
                Console.Write($"{ä}  ");
            }
        }
    }
}
