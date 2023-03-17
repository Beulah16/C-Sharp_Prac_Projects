using System;
namespace Exercices
{
    class Student
    {
        static void Main(string[] args)
        {
            //29. C# program to calculate the total marks, percentage and division of student.

            Console.Write("Welcome to the students dashboard, please fill in the required fields. \nFullname:");
            string fullname = Console.ReadLine();
            Console.Write("Department:");
            string dep = Console.ReadLine();
            Console.Write("Subject Scores; \nEnglish:");
            int eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mathematics:");
            int mat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Physics:");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry:");
            int che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Biology:");
            int bio = Convert.ToInt32(Console.ReadLine());
            
            int total_mrk = eng + mat + phy + che + bio;
            var percentage = total_mrk / 5;

            if(percentage >= 70)
            {
                Console.WriteLine("You got a First Class Degree!");
            } else if(percentage >= 55 && percentage < 70)
            {
                Console.WriteLine("You got a Second Class Upper!");
            } else if(percentage > 40 && percentage < 55)
            {
                Console.WriteLine("You got a Second Class Lower!");
            } else if(percentage <= 40 && percentage >= 0)
            {
                Console.WriteLine("You're carrying Over!");
            }else
            {
                Console.WriteLine("Invalid Scores");
            }
        }
    }
}
