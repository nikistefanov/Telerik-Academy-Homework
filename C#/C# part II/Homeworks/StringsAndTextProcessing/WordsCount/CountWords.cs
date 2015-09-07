//Problem 22. Words count

//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;

class CountWords
{
    static void Main()
    {
        char[] separaotrs = { ',', '.', ' ', '\t', '\n', '!', '?', '"' };
        Console.WriteLine("Enter text here: ");
        string[] text = Console.ReadLine().Split(separaotrs).ToArray();
        var wordAndCount = new Dictionary<string, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (!wordAndCount.ContainsKey(text[i]))
            {
                wordAndCount.Add(text[i], 1);
            }
            else if (wordAndCount.ContainsKey(text[i]))
            {
                wordAndCount[text[i]] += 1;
            }
        }
        Console.WriteLine();

        var sortedDict = from entry in wordAndCount orderby entry.Value descending select entry;
        foreach (var item in sortedDict)
        {
            Console.WriteLine("{0} --> {1} time(s)", item.Key, item.Value);
        }
    }
}
