//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;

class WordsOrder
{
    static void Main()
    {
        char[] separaotrs = { ',', '.', ' ', '\t', '\n', '!', '?', '"' };
        //string text = "Separated by spaces and prints the list";
        Console.WriteLine("Enter text to be sorted: ");
        string text = Console.ReadLine();
        string[] words = text.Split(separaotrs).OrderBy(a => a).ToArray();
        Console.WriteLine("Sorted in alphabetical order:");
        foreach (var word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}
