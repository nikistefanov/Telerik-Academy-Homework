//Problem 6. Binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinToHex
{
    static void Main()
    {
        Console.Write("Enter a number in binary: ");
        string numberInBin = Console.ReadLine();
        string newNumber = numberInBin;

        for (int i = 0; i < (newNumber.Length % 4); i++)
        {
            newNumber = "0" + newNumber;
        }

        string result = "";
        for (int i = 0; i < newNumber.Length; i += 4)
        {
            switch (newNumber.Substring(i, 4))
            {
                case "0000": result += 0; break;
                case "0001": result += 1; break;
                case "0010": result += 2; break;
                case "0011": result += 3; break;
                case "0100": result += 4; break;
                case "0101": result += 5; break;
                case "0110": result += 6; break;
                case "0111": result += 7; break;
                case "1000": result += 8; break;
                case "1001": result += 9; break;
                case "1010": result += "A"; break;
                case "1011": result += "B"; break;
                case "1100": result += "C"; break;
                case "1101": result += "D"; break;
                case "1110": result += "E"; break;
                case "1111": result += "F"; break;
            }
        }


        Console.WriteLine("{0} in hexadecimal  {1}", numberInBin, result);
    }

}

