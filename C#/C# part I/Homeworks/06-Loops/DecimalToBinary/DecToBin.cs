//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecToBin
{
    static void Main()
    {
        Console.Write("Enter a number in decimal: ");
        int decNumber = int.Parse(Console.ReadLine());
        int decNumCopy = decNumber;
        int decRemainder;
        string result = null;

        while (decNumber > 0)
        {
            decRemainder = decNumber % 2;
            decNumber /= 2;
            result = decRemainder.ToString() + result;
        }
        Console.WriteLine("{0} in binary:  {1}",decNumCopy, result);
    }
}