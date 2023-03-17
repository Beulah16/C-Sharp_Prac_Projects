using System;
namespace Exercices
{
    class Equal
    {
        static void Main(string[] args)
        {
            //26.C# program to accept two integers and check whether they are equal or not.

            int num1, num2;
            Console.WriteLine("Hello User! \nEnter 2 integers: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine()); 

            if(num1 == num2 )
            {
                Console.WriteLine("These integers are equal");
            } else
            {
                Console.WriteLine("These inegers are not equal");
            }
        }
    }
}
