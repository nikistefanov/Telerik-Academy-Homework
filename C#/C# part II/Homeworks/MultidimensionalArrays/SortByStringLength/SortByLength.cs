//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;

class SortByLength
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array:");
        int n = int.Parse(Console.ReadLine());

        string[] arrayOfString = new string[n];
        string star = new string('*', 40);
        for (int i = 0; i < arrayOfString.Length; i++)
        {
            Console.Write("index[{0}]=", i);
            arrayOfString[i] = Console.ReadLine();
        }
        Console.WriteLine(star);
        Console.WriteLine("Before sorting: ");
        Console.WriteLine(string.Join(", ", arrayOfString));
        Array.Sort(arrayOfString, (x, y) => x.Length.CompareTo(y.Length));
        Console.WriteLine(star);
        Console.WriteLine("After sorting: ");
        Console.WriteLine(string.Join(", ", arrayOfString));
        Console.WriteLine(star);
    }
}