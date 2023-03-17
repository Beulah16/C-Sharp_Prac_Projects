using System;
namespace Exercices
{
    class ANSCII
    {
        static void Main(string[]args)
        {
            //10. C# Program to Print ASCII Value
            
            /*char alpha;
            Console.Write("Hello User \nEnter a character:");
            alpha = Convert.ToChar(Console.Read());
            Console.WriteLine($"\nANSCII value of {alpha} is {Convert.ToInt32(alpha)}");*/

            
            while (true)
            {
                char alpha;
                Console.Write("Hello User \nEnter a character:");
                alpha = Convert.ToChar(Console.Read());
                int alp = alpha;
                Console.WriteLine(alp);
            }
            
           /* while (true)
            {
                int alp;
                Console.Write("Hello User \nEnter a number:");
                alp = Convert.ToInt32(Console.ReadLine());
                char alpha = Convert.ToChar(alp);
                Console.WriteLine(alpha);
            }*/
        }
    }
}