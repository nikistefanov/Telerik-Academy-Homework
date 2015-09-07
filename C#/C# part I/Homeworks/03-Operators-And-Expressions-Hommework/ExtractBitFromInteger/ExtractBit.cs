//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.


using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the index: ");
        int bitIndex = int.Parse(Console.ReadLine());
        int mask = 1 << bitIndex;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> bitIndex;
        Console.WriteLine("The value of the bit at index {0} of number {1} is {2}!", bitIndex, number, bit);
    }
}
