using System;
class NumWords
{
    static void Main(string[] args)
    {
        //52.	Write C# program to print number in words
        Console.WriteLine("Hello User! \nThis program prints the digits of a number in words");
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int num = 0;
        while (n != 0)
        {
            num = (num * 10) + (n % 10);
            n /= 10;
        }
        //print corresponding digit in words till num becomes 0
        while (num != 0)
        {
            switch (num % 10)
            {
                case 0:
                    Console.Write("zero ");
                    break;
                case 1:
                    Console.Write("one ");
                    break;
                case 2:
                    Console.Write("two ");
                    break;
                case 3:
                    Console.Write("three ");
                    break;
                case 4:
                    Console.Write("four ");
                    break;
                case 5:
                    Console.Write("five ");
                    break;
                case 6:
                    Console.Write("six ");
                    break;
                case 7:
                    Console.Write("seven ");
                    break;
                case 8:
                    Console.Write("eight ");
                    break;
                case 9:
                    Console.Write("nine ");
                    break;
            }
            num = num / 10;
        }
    }
}