using System;
namespace Exercices
{
    class ArmstrongN
    {
        static void Main(string[] args)
        {
            //48. Write C# program to find Armstrong numbers between 1 to n

            Console.WriteLine("Hello User! This is a program that find Armstrong numbers between 1 to n");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            /*A number is thought of as an Armstrong number if...
             *the sum of its own digits raised to the power number of the digits gives the number itself.*/
            

            for (int k = 1; k <= num; k++)
            {
                string numb = Convert.ToString(k);
                int exp = numb.Length;   //used to get the power from the number of digits
                int arm;
                int sum = 0;
                if (exp == 1)
                {
                    Console.WriteLine($"{k} is an Armstrong number");
                }
                else if (exp >= 3)
                {
                    int dig = k;
                    int temp = dig;
                    while (dig > 0)
                    {
                        int rm = dig%10;  //Gets each digit of the number
                        dig /= 10;
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
                }
            }
        }
    }
}