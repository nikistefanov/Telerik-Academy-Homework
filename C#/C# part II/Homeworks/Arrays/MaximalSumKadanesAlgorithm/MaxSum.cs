//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.

//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	--->  2, -1, 6, 4

using System;

class MaxSum
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

        int currentSum = arrayOfNumbers[0];
        int start = 0;
        int end = 0;
        int tempStart = 0;
        int maxSum = arrayOfNumbers[0];

        for (int i = 1; i < arrayOfNumbers.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = arrayOfNumbers[i];
                tempStart = i;
            }
            else
            {
                currentSum += arrayOfNumbers[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;

                start = tempStart;
                end = i;
            }
        }

        Console.WriteLine("The best sum is: {0} ", maxSum);

        Console.Write("The best sequence is ---> ");

        for (int i = start; i <= end; i++)
        {
            Console.Write(arrayOfNumbers[i] + " ");
        }
        Console.WriteLine();
    }
}