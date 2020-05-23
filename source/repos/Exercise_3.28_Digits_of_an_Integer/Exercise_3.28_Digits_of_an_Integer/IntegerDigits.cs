/*
 * Exercise 3.28. Application that takes in a 5 digit integer and displays the digits with 3
 * spaces between each digit.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3._28_Digits_of_an_Integer
{
    class IntegerDigits
    {
        static void Main(string[] args)
        {
            // declare variables for the individual digits
            int number1;
            int number2;
            int number3;
            int number4;
            int number5;

            // prompt the user and assign to userNumber variable
            Console.Write("Enter in a 5 digit integer: ");
            int userNumber = int.Parse(Console.ReadLine());

            // parse out the individual digits and assign to respective variable
            number5 = (int)((userNumber / 1) % 10);
            number4 = (int)((userNumber / 10) % 10);
            number3 = (int)((userNumber / 100) % 10);
            number2 = (int)((userNumber / 1000) % 10);
            number1 = (int)((userNumber / 10000) % 10);

            // display the altered 5 digit integer
            Console.Write($"Now with a little bit of magic your number has spaces! " +
                $"{number1}   {number2}   {number3}   {number4}   {number5}");

            // keep the console open after the app finishes execution
            Console.ReadLine();

        }// end of Main method
    }// end of IntegerDigits class
}
