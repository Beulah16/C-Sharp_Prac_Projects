using System;
namespace Exercices
{
    class Vowel
    {
        static void Main(string[] args)
        {
            //20. C# Program to Check whether an alphabet is a vowel or not.
           
                char alpha;
                Console.Write("Hello User \nEnter an alphabet: ");
                alpha = Convert.ToChar(Console.ReadLine().ToLower());

                //Numbers from 0 - 9 and symbols are stored as characters with ANSCII values
                int alp = Convert.ToInt32(alpha);
                if (alp >= 97 && alp <= 122)//makes sure the user doesn't enter a numeric character
                {
                    switch (alpha)
                    {
                        case 'a':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'e':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'i':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'o':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        case 'u':
                            Console.WriteLine("The Alphabet is vowel");
                            break;
                        default:
                            Console.WriteLine("The Alphabet is not a vowel");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("That is not an alphabet, Please enter a valid  alphabet!");
                }
        }
    }
}