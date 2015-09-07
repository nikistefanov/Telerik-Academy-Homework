//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.
//Example:

//input	    output
//256	    652
//123.45	54.321

using System;
using System.Collections.Generic;
using System.Linq;

class ReversingNums
{
    static void Main()
    {
        Console.Write("Please enter your number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        ReverseNumber(number);
    }

    static void ReverseNumber(decimal number)
    {
        char[] numberToChar = number.ToString().ToCharArray();
        Array.Reverse(numberToChar);
        string numberToString = new string(numberToChar);
        decimal reverseNumber = decimal.Parse(numberToString);

        Console.WriteLine("Before {0, 3} \nAfter  {1, 3}", number, reverseNumber);
    }
}
