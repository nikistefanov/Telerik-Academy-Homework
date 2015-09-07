//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];

        Random rnd = new Random();

        int digit = k;
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            //// using user's input
            //Console.Write("index[{0}]= ", i);
            //arrayOfNumbers[i] = int.Parse(Console.ReadLine());

            // using random numbers
            arrayOfNumbers[i] = rnd.Next(1, 101);
        }

        Array.Sort(arrayOfNumbers);
        string text = string.Join(", ", arrayOfNumbers);
        Console.WriteLine(text);
        if (arrayOfNumbers[0] > k)
        {
            Console.WriteLine("No number!");
            return;
        }
        else
        {
            while (Array.BinarySearch(arrayOfNumbers, digit) < 0)
            {
                digit--;
            }
        }
        Console.WriteLine("The largest number is {0} <= {1}",digit, k);
    }
}
