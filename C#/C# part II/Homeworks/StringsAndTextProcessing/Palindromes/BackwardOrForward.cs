//Problem 20. Palindromes

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Linq;
using System.Collections.Generic;

class BackwardOrForward
{
    static void Main()
    {
        char[] separaotrs = { ',', '.', ' ', '\t', '\n', '!', '?', '"' };
        Console.WriteLine("Enter text so we can extract all the palindromes: ");
        string[] text = Console.ReadLine().Split(separaotrs).ToArray();
        //string[] text = { ABBA, lamal, BaaB, gereg, Ho };

        var uniqueText = new SortedSet<string>();

        foreach (var item in text)
        {
            for (int i = 0; i < item.Length; i++)
            {
                if (item[i] == item[item.Length - i - 1]) uniqueText.Add(item);
                else break;
            }
        }
        Console.WriteLine(new string('*', 60));
        foreach (var item in uniqueText)
        {
            Console.Write(item + "\t");
        }
        Console.WriteLine();
    }
}
