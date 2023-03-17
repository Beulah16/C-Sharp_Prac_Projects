using System;
namespace Exercices
{
    class UppLow
    {
        static void Main(string[] args)
        {
            //22. C# program to check uppercase or lowercase alphabets.
           
                char alpha;
                Console.Write("Hello User \nEnter an alphabet: ");
                alpha = Convert.ToChar(Console.Read());

                
                int alp = Convert.ToInt32(alpha);
                if (alp >= 97 && alp <= 122)
                {
                   Console.WriteLine("This is a lowercase alphabet!");
                }
                else if(alp >= 65 && alp <= 90)
                {
                    Console.WriteLine("This is an uppercase alphabet!");
                }
                else
                {
                    Console.WriteLine("This is not an alphabet! Please enter a valid alphabet!");
                }
        }
    }
}