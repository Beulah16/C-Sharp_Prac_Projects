using System;
namespace Exercices
{
	class Calculator
	{
		static void Main(string[]args)
		{
			//57.Write C# program to create calculator using switch Statement
			Console.WriteLine("Hello User! /nThis is a program that creates a calculator");
			Console.WriteLine("Input Operation:");
			var num1 = Convert.ToSingle(Console.ReadLine());
			char carc = Convert.ToChar(Console.ReadLine());
			var num2 = Convert.ToSingle(Console.ReadLine());

			switch(carc)
			{
				case '+':
					Console.WriteLine("= " + (num1 + num2));
					break;
				case '-':
					 Console.WriteLine("= " + (num1 - num2));
					 break;
				case '*':
					  Console.WriteLine("= " + (num1 * num2));
					  break;
				case '/':
					   Console.WriteLine("= " + (num1 / num2));
					   break;
				case '%':
					    Console.WriteLine("= " + (num1 % num2));
					    break;
				default:
					     Console.WriteLine("Invalid expression");
					     break;
			}
		}
	}
}


