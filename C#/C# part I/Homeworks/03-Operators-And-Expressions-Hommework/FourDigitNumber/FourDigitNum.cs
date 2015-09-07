//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNum
{
    static void Main()
    {
        Console.WriteLine("Please enter a number that does not start with 0 and it's exactly four digit: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("I said exactly 4 digits and cannot start with 0!");
            Console.Write("Here's an example --> 2011. Now again: ");
            number = int.Parse(Console.ReadLine());
        }

        int a = number / 1000;          //first digit
        int b = (number / 100) % 10;    //second digit
        int c = (number / 10) % 10;     //third digit
        int d = number % 10;            //fourth digit

        string str = new string('*', 60);
        Console.WriteLine(str);
        Console.WriteLine("The sum of the digits is -> {0}", a+b+c+d);
        Console.WriteLine("The number in reversed order is -> {3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("Let's put the last digit in the first position -> {3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("Finally let's swap the second and the third digits - > {0}{2}{1}{3}", a, b, c, d);
        Console.WriteLine(str);
    }
}