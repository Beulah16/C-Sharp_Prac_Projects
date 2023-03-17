using System;
namespace Practice
{
    class Arthm_Ops
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hello User! \nPlease input two numbers to perform all arithmetic operations");
            var num1 = Convert.ToSingle(Console.ReadLine());
            var num2 = Convert.ToSingle(Console.ReadLine());

            var add = num1+num2;
            var sub = num1-num2;
            var mul = num1*num2;
            var div = num1/num2;
            var mod = num1%num2;
            Console.WriteLine($"Sum = {add}");
            Console.WriteLine($"Difference = {sub}");
            Console.WriteLine($"Product = {mul}");
            Console.WriteLine($"Quotient = {div}");
            Console.WriteLine($"Remainder = {mod}");
            
            //Basic Calculator ☻
            /*var c = Convert.ToSingle(Console.ReadLine());
            char s = Convert.ToChar(Console.ReadLine());
            var d = Convert.ToSingle(Console.ReadLine());
            switch(s)
            {
                case '+':
                Console.WriteLine(c+d);
                break;
                
                case '-':
                Console.WriteLine(c-d);
                break;
                
                case '*':
                Console.WriteLine(c*d);
                break;
                
                case '/':
                Console.WriteLine(c/d);
                break;
                
                case '%':
                Console.WriteLine(c%d);
                break;
            }*/
        }
    }
}