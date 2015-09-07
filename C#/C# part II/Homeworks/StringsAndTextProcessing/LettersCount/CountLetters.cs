//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Linq;

class CountLetters
{
    static void Main()
    {
        Console.WriteLine("Enter text here:");
        string text = Console.ReadLine();
        var charAndCount = new Dictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (!charAndCount.ContainsKey(text[i]) && char.IsLetter(text[i]))
            {
                charAndCount.Add(text[i], 1);
            }
            else if (charAndCount.ContainsKey(text[i]) && char.IsLetter(text[i]))
            {
                charAndCount[text[i]] += 1;
            }
        }
        Console.WriteLine();
        
        var sortedDict = from entry in charAndCount orderby entry.Value descending select entry;
        foreach (var item in sortedDict)
        {
            Console.WriteLine("{0} --> {1} time(s)", item.Key, item.Value);
        }
    }
}
