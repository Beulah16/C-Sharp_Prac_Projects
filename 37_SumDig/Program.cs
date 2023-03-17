using System;
namespace Exercices
{
    class SumDig
    {
        static void Main(string[] args)
        {
            //37.Write C# program to print sum of digits entered by user

            Console.WriteLine("Hello User! This is a program that prints sum of digits of entered integer");
            Console.Write("Enter integer: ");
            int num, sum;
            num = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            /*A digit of an integer is like the alphabet of that integer,e.g; digits of 345 are 3, 4 and 5.
             *Therefore, to find the digits of an integer, first find the remainder of that number after dividing by 10
             *Add to the value of the variable holing the sum
             *Divide the integer by 10 and assign the gotten value to the vaiable holding the integer
             *Calculate the modulus again, and repeat the next aforementioned processes*/

            while(num > 0)
            {
                int rm = num % 10;
                num /= 10;
                sum += rm;
            }
            Console.WriteLine($"Sum of digits= {sum}");
        }
    }
}