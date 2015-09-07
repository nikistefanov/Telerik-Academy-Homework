//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input	output
//.NET	platform for applications from Microsoft
//CLR	managed execution environment for .NET
//namespace	hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Linq;

class DictionaryOfWords
{
    static void Main()
    {
        Console.Title = "Simple dictionary";

        var dict = new Dictionary<string, string>();
        dict.Add(".NET", "Platform for applications from Microsoft");
        dict.Add("CLR", "Managed execution environment for .NET");
        dict.Add("Namespace", "Hierarchical organization of classes");
        dict.Add("String", "Object of type String whose value is text.");


        Console.WriteLine("For wich of these words do you want to get an explanation:");
        foreach (var key in dict)
        {
            Console.WriteLine(key.Key);
        }
        string wantedKey = Console.ReadLine();
        try
        {
            Console.WriteLine(dict[wantedKey]);
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine("Please, enter a valid word from the words above.");
        }
    }
}
