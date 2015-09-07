//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

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
        Console.WriteLine("{0} in binary:  {1}", decNumCopy, result);
    }
}

