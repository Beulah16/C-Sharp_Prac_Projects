using System;
namespace Exercices
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            //47.Write C# program to check whether a number is Armstrong number or not

            Console.WriteLine("Hello User! This is a program that checks for an Armstrong number");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            /*A number is thought of as an Armstrong number if...
             *the sum of its own digits raised to the power number of the digits gives the number itself.*/
            string numb = Convert.ToString(num);
            int exp = numb.Length;   //used to get the power from the number of digits
            int arm;
            int sum = 0;


            
                if (exp == 1)
                {
                    Console.WriteLine($"{num} is an Armstrong number");
                }
                else if (exp > 1)
                {
                    while (num > 0)
                    {
                    int rm = num%10;  //Gets each digit of the number
                    num /= 10;
                    arm = rm * rm;  //an attemt to find the power
                    for (int i = 2; i < exp; i++)
                    {
                        arm = arm * rm; //raises the digit to the power required
                    }
                    sum = sum + arm;  //adds the product to the sum value
                    }
                    if (sum == temp)
                    {
                        Console.WriteLine($"{temp} is an Armstrong number");
                    }
                    else
                    {
                        Console.WriteLine($"{temp} is not an Armstrong number");
                    }
                }
            
        }
    }
}