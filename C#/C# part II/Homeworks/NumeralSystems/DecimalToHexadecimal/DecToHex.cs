//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecToHex
{
    static void Main()
    {
        Console.Write("Enter a number in decimal: ");
        long numberInDecimal = long.Parse(Console.ReadLine());
        long numberForPrint = numberInDecimal;
        long result;
        string numberInHex = "";

        while (numberInDecimal > 0)
        {
            result = numberInDecimal / 16;
            long digitInHex = numberInDecimal % 16;
            numberInDecimal = result;

            switch (digitInHex)
            {

                case 10: numberInHex = 'A' + numberInHex; break;
                case 11: numberInHex = 'B' + numberInHex; break;
                case 12: numberInHex = 'C' + numberInHex; break;
                case 13: numberInHex = 'D' + numberInHex; break;
                case 14: numberInHex = 'E' + numberInHex; break;
                case 15: numberInHex = 'F' + numberInHex; break;
                default: numberInHex = digitInHex + numberInHex; break;
            }
        }
        Console.WriteLine("{0} in hexadecimal:  {1}", numberForPrint, numberInHex);
    }
}
