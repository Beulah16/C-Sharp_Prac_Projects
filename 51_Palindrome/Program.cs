using System;
namespace Exercices
{
    class Palindrome
    {
        static void Main(string[]args)
        {
            //51. Write C# program to check whether a number is palindrome or not
            while(true)
            {
                Console.WriteLine("Hello User! \nThis program check whether a number is palindrome or not");
                Console.Write("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0 && num <=9)
                {
                    Console.WriteLine("This number is palindromic");
                }
                else
                {
                    string numb = num.ToString();
                    //get the first digit
                    char first = numb[0];
                    //get the last digit
                    char last = numb[numb.Length - 1];
                    string concat = last+numb.Substring(1, numb.Length - 2)+first;
                    if (concat == numb)
                    {
                        Console.WriteLine("This number is palindromic");
                    }
                    else
                    {
                        Console.WriteLine("This number is not palindromic");
                    }
                }
               
            }
            
        }
    }
}