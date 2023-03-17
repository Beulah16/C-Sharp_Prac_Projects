using System;
namespace Exercices
{
    class NairaNotes
    {
        static void Main(string[]args)
        {
            //31.C# program to count total number of notes in entered amount.
            Console.Write("Hello user! This program counts total number of Currently Valid Naira notes.\nAmount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int note5, note10, note20, note50, note100, note200, note500;
            note5 = note10 = note20 = note50 = note100 = note200 = note500 = 0;

                /*When the amount of money entered is greater than 100, 
                 * the money is dividd by 100 to get the number of 100 naira notes
                 * then the sum of the 100 naira notes is subtracted from the Amount of money
                 * therefore, number of other notes are calculated using the  remaining money
                 */
            if (amount >= 500)
            {
                note500 = amount / 500;
                amount -= note500 *500;
            } 
            if (amount >= 200)
            {
                note200 = amount / 200;
                amount -= note200 *200;
            } if (amount >= 100)
            {
                note100 = amount / 100;
                amount -= note100 *100;
            } if (amount >= 50)
            {
                note50 = amount / 50;
                amount -= note50 *50;
            } if (amount >= 20)
            {
                note20 = amount / 20;
                amount -= note20 *20;
            } if(amount >= 10)
            {
                note10 = amount / 10;
                amount -= note10 *10;
            } if (amount >= 5)
            {
                note5 = amount / 5;
                amount -= note5 *5;
            }
            Console.WriteLine("\nTotal number of notes:");
            Console.WriteLine("500 naira notes = " + note500);
            Console.WriteLine("200 naira notes = " + note200);
            Console.WriteLine("100 naira notes = " + note100);
            Console.WriteLine("50 naira notes= "+ note50);
            Console.WriteLine("20 naira notes= "+ note20);
            Console.WriteLine("10 naira notes= "+ note10);
            Console.WriteLine("5 naira notes= "+ note5);
        }
    }
}
