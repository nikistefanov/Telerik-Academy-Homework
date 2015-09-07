//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.
//Example:

//input	output
//C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!

using System;
using System.Linq;

class SentenceInReverseOrdeer
{
    static void Main()
    {
        char[] endOfSentence = { '.', '!', '?', ';', ':' };
        string text = "C# is not C++, not PHP and not Delphi!";
        char symbol = text.Last();
        var reversedText = text.Remove(text.Length - 1).Insert(0, symbol + " ").Split(' ').Reverse().ToArray();

        for (int i = 0; i < reversedText.Length; i++)
        {
            if (i != reversedText.Length - 2) Console.Write(reversedText[i] + " ");
            else Console.Write(reversedText[i]);
        }
        Console.WriteLine();
        
    }
}
