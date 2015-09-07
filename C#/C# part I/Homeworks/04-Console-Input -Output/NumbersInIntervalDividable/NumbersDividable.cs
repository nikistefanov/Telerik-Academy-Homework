//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersDividable
{
    static void Main()
    {
        Console.Write("Please, enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        int tempNum = 0;
        int counter = 0;

        for (int i = firstNum; i <= secondNum; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("Voala ---> {0} numbers exist between {1} and {2}, that the reminder of the division by 5 is 0.", counter, firstNum, secondNum);
    }
}