using System;
namespace Exercices
{
    class Eligibility
    {
        static void Main(string[] args)
        {
            //28. C# program to find the eligibility of admission for an engineering course based on the criteria.

            Console.Write("Welcome to the students dashboard, please fill in the required fields. \nFullname:");
            string fullname = Console.ReadLine();
            Console.Write("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Jamb Scores \nMathematics:");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("Physics:");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry:");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            
            //The criteria requires that the student must score above 190 in all the aforementioned subjects
            if(maths >= 190 && physics >= 190 && chemistry >= 190)
            {
                Console.WriteLine("You're eligible for this admission!");
            }else
            {
                Console.WriteLine("You're not eligible for this admission!");
            }
        }
    }
}
