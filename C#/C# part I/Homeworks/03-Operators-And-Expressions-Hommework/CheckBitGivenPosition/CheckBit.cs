//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckBit
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
        bool checkIndex = true;
        if (bit == 1)
        {
            Console.WriteLine("Yes! The bit at position {0} is {1}!", bitIndex, bit);
        }
        else
        {
            Console.WriteLine("Oh nooo It's a me, Zerooo!");
        }
    }
}
