//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class Selection
{
    static void Main()
    {
        //int[] arrayOfNumbers = { 8, 1, 3, 9, 6, 7, 2 };
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];

        Console.WriteLine("Enter the array elemets:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Index[{0}] ", i);
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        int minValue = int.MaxValue;
        int minIndex = -1;
        Console.WriteLine("Before sorting.");
        Console.WriteLine(string.Join(", ", arrayOfNumbers));
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            minValue = int.MaxValue;
            for (int j = i + 1; j < arrayOfNumbers.Length; j++)
            {
                if (minValue > arrayOfNumbers[j])
                {
                    minValue = arrayOfNumbers[j];
                    minIndex = j;
                }
            }

            int tempNum = arrayOfNumbers[i];
            arrayOfNumbers[i] = minValue;
            arrayOfNumbers[minIndex] = tempNum;
        }
        Console.WriteLine("After sorting.");
        Console.WriteLine(string.Join(", ", arrayOfNumbers));
    }
}
