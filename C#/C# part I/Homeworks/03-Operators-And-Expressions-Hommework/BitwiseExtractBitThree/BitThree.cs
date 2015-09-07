//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class BitThree
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int bitIndex = 3;
        int mask = 1 << bitIndex;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> bitIndex;
        Console.WriteLine("The value of the bit at index 3 of number {0} is {1}!",number, bit);
        
    }
}
