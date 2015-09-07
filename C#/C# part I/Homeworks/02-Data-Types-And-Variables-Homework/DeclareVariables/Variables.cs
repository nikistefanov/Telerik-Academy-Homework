//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class Variables
{
    static void Main()
    {
        byte firstNum = 97;             
        sbyte secondNum = -115;         
        short thirdNum = -10000;        
        ushort fourthNum = 52130;       
        int fifthNum = 4825932;         

        Console.WriteLine("I've decided to declare them in this order:");
        Console.WriteLine(" byte\t->\t{0}\n sbyte\t->\t{1}\n short\t->\t{2}\n ushort\t->\t{3}\n int\t->\t{4}\n", firstNum, secondNum, thirdNum, fourthNum, fifthNum);
    }
}