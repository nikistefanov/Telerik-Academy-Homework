//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;

class BinToDec
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();
        long dec = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i - 1] == '0')
            {
                continue;
            }

            dec += (long)Math.Pow(2, i);
        }

        Console.WriteLine("{0} in decimal:  {1}",binary, dec);
    }
}
