//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBin
{
    static void Main()
    {
        Console.Write("Enter a number in hexadecimal: ");
        string numberInHex = Console.ReadLine();
        string numberInBin = "";

        for (int i = 0; i < numberInHex.Length; i++)
        {
            switch (numberInHex[i])
            {
                case '0': numberInBin += "0000"; break;
                case '1': numberInBin += "0001"; break;
                case '2': numberInBin += "0010"; break;
                case '3': numberInBin += "0011"; break;
                case '4': numberInBin += "0100"; break;
                case '5': numberInBin += "0101"; break;
                case '6': numberInBin += "0110"; break;
                case '7': numberInBin += "0111"; break;
                case '8': numberInBin += "1000"; break;
                case '9': numberInBin += "1001"; break;
                case 'A': numberInBin += "1010"; break;
                case 'B': numberInBin += "1011"; break;
                case 'C': numberInBin += "1100"; break;
                case 'D': numberInBin += "1101"; break;
                case 'E': numberInBin += "1110"; break;
                case 'F': numberInBin += "1111"; break;
                default: numberInBin = "Error"; break;
            }
        }
        Console.WriteLine("{0} in binary:  {1}",numberInHex, numberInBin);
    }
}
