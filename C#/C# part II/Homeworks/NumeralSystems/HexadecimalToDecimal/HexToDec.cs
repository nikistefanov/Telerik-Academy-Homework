//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexToDec
{
    static void Main()
    {
        Console.Write("Enter a number in hexadecimal: ");
        string numberInHex = Console.ReadLine();
        long numberInDec = 0;
        bool noHex = true;
        for (int i = 0; i < numberInHex.Length; i++)
        {
            switch (numberInHex[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': numberInDec = numberInDec + (long)char.GetNumericValue(numberInHex[i]) * (long)Math.Pow(16, (numberInHex.Length - 1 - i)); break;
                case 'A': numberInDec = numberInDec + 10 * (long)Math.Pow(16, (numberInHex.Length - 1 - i)); break;
                case 'B': numberInDec = numberInDec + 11 * (long)Math.Pow(16, (numberInHex.Length - 1 - i)); break;
                case 'C': numberInDec = numberInDec + 12 * (long)Math.Pow(16, (numberInHex.Length - 1 - i)); break;
                case 'D': numberInDec = numberInDec + 13 * (long)Math.Pow(16, (numberInHex.Length - 1 - i)); break;
                case 'E': numberInDec = numberInDec + 14 * (long)Math.Pow(16, (numberInHex.Length - 1 - i)); break;
                case 'F': numberInDec = numberInDec + 15 * (long)Math.Pow(16, (numberInHex.Length - 1 - i)); break;
                default: Console.WriteLine("Invalid Hexadecimal number!"); noHex = false; break;
            }
        }
        if (noHex)
        {
            Console.WriteLine("{0} in decimal:  {1}", numberInHex , numberInDec);
        }
        else
        {
            return;
        }
    }
}
