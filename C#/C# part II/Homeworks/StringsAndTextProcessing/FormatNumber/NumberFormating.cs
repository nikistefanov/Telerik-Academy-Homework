//Problem 11. Format number

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;
using System.Globalization;
using System.Threading;

class NumberFormating
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a number: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15}  {1,15} {2,15} {3,15}", "Decimal", "Hexadecimal", "Percentage", "Exponential");
            Console.WriteLine("{0,15:D} {0,15:X} {1,15:P0} {0,15:E1}", number, (double)number / 100);
        }
        catch (FormatException)
        {

            Console.WriteLine("Please, enter a valid number!");
        }
    }
}
