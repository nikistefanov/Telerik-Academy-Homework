//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the index: ");
        int bitIndex = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for this index (0 or 1): ");
        int bitValue = int.Parse(Console.ReadLine());

        int mask = 1 << bitIndex;
        int numberAndMask = number | mask;
        int bit = numberAndMask >> bitIndex;
        string text = new string('*', 45);

        Console.WriteLine(text);
        Console.WriteLine("Binary code of number {0} is:", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(text);

        if (bitValue == 1)
        {
            Console.WriteLine("You've chosen 1!");
            Console.Write(Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));
            Console.WriteLine(" ---> This is number {0}", numberAndMask);
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("You've chosen 0!");
            mask = ~(1 << bitIndex);
            numberAndMask = number & mask;
            Console.Write(Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));
            Console.WriteLine(" ---> This is number {0}", numberAndMask);
            Console.WriteLine(text);
        }
    }
}
