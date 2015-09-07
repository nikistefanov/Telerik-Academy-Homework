//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Linq;

class Binary
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];

        Console.WriteLine("Enter the array elemets:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Index[{0}] ", i);
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        if (n == 1)
        {
            Console.WriteLine("No point of looking...");
        }
        Array.Sort(arrayOfNumbers);


        Console.Write("Please enter the number that you are looking for: ");
        int searchNum = int.Parse(Console.ReadLine());
        int start = 0;
        int end = arrayOfNumbers.Length - 1;
        int middle = 0;

        while (end >= start)
        {
            middle = (end + start) / 2;
            if (searchNum == arrayOfNumbers[middle])
            {
                break;
            }
            else if (searchNum > arrayOfNumbers[middle])
            {
                start = middle++;
            }
            else
            {
                end = middle--;
            }
        }
        Console.WriteLine("Number {0} is at index[{1}]", searchNum, middle);
    }
}