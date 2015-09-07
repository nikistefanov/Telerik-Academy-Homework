//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.

using System;
using System.Linq;

class Frequent
{
    static void Main()
    {
        //int[] arrayOfNumbers = { 8, 8, 8, 8, 1, 3, 9, 6, 7, 3, 2, 2, 2};
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
        int maxCounter = 0;
        int currCounter = 1;
        int frequentNum = 0;
        for (int i = 1; i < arrayOfNumbers.Length; i++)
        {
            if (arrayOfNumbers[i] == arrayOfNumbers[i - 1])
            {
                currCounter++;
            }
            else
            {
                currCounter = 1;
            }
            if (currCounter > maxCounter)
            {
                maxCounter = currCounter;
                frequentNum = arrayOfNumbers[i];
            }
        }
        Console.WriteLine(string.Join(", ", arrayOfNumbers));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The most frequent number is this array is {0} ---> {1}", frequentNum, maxCounter);
    }
}