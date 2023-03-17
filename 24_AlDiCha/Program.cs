using System;
namespace Exercices
{
    class AlDiCha
    {
        static void Main(string[] args)
        {
            //24. C# program to check whether a character is alphabet, digit or special character.
           
                char cha;
                Console.Write("Hello User \nEnter a character: ");
                cha = Convert.ToChar(Console.Read());

                int ans = Convert.ToInt32(cha);
                if ((ans >= 97 && ans <= 122 )|| (ans >= 65 && ans <= 90))
                {
                    Console.WriteLine("This is an alphabet");
                }
                else if(ans >= 48 && ans <= 57 )
                {
                    Console.WriteLine("This is a digit");
                }
                else
                {
                    Console.WriteLine("This is a special character");
                }
        }
    }
}