using System;
namespace Exercices
{
    class VoCon
    {
        static void Main(string[] args)
        {
            //23. C# program to check if entered character is a vowel or consonant.
           
                char alpha;
                Console.Write("Hello User \nEnter an alphabet: ");
                alpha = Convert.ToChar(Console.ReadLine().ToLower());

                
                int alp = Convert.ToInt32(alpha);
                if (alp >= 97 && alp <= 122)
                {
                    switch (alpha)
                    {
                        case 'a':
                            Console.WriteLine("This Alphabet is a vowel");
                            break;
                        case 'e':
                            Console.WriteLine("This Alphabet is a vowel");
                            break;
                        case 'i':
                            Console.WriteLine("This Alphabet is a vowel");
                            break;
                        case 'o':
                            Console.WriteLine("This Alphabet is a vowel");
                            break;
                        case 'u':
                            Console.WriteLine("This Alphabet is a vowel");
                            break;
                        default:
                            Console.WriteLine("This Alphabet is a consonant");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("This is not an alphabet, Please enter a valid  alphabet!");
                }
        }
    }
}