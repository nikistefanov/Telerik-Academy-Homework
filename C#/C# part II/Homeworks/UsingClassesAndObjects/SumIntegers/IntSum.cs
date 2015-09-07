//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:

//input	            output
//"43 68 9 23 318"	461

using System;
using System.Linq;

class IntSum
{
    static int SumOfIntegers(params int[] numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static void Main()
    {
        char[] separators = { ',', '.', ' ', '\t', '\n', '\\', '/' };
        Console.WriteLine("Please, enter your numbers separated by space:");
        string numbersToString = Console.ReadLine();
        int[] numbersInputed = numbersToString.Split(separators).Select(int.Parse).ToArray();
        Console.WriteLine("And the sum is {0}!", SumOfIntegers(numbersInputed));
    }
}
