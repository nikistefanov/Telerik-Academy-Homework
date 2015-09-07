//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexToDec
{
    static void Main()
    {
        string input = Console.ReadLine();
        long number = 0;
        bool noHex = true;
        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
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
                case '9': number = number + (long)char.GetNumericValue(input[i]) * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'A': number = number + 10 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'B': number = number + 11 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'C': number = number + 12 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'D': number = number + 13 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'E': number = number + 14 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                case 'F': number = number + 15 * (long)Math.Pow(16, (input.Length - 1 - i)); break;
                default: Console.WriteLine("Invalid Hexadecimal number!"); noHex = false; break;
            }
        }
        if (noHex)
        {
            Console.WriteLine(number); 
        }
        else
        {
            return;
        }
    }
}