using System;
namespace Exercices
{
    class Eligible
    {
        static void Main(string[] args)
        {
            //27. C# program to detrermine a candidate’s age is eligible for casting the vote or not.

            Console.Write("Welcome to the voters dashboard, please fill in the required fields. \nFullname:");
            string fullname = Console.ReadLine();
            Console.Write("Age:");
            int age = Convert.ToInt32(Console.ReadLine()); 

            if(age >= 18)
            {
                Console.WriteLine("You're eligible to vote!");
            }else
            {
                Console.WriteLine("You're not eligible to vote!");
            }
        }
    }
}
