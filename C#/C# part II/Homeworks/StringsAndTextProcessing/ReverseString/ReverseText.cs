//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input	output
//sample	elpmas

using System;
using System.Linq;


class ReverseText
{
    static void Main()
    {
        Console.Write("Enter text here: ");
        string text = Console.ReadLine();
        var reversedText = text.Reverse();
        Console.Write("In reversed order: ");
        foreach (var symbol in reversedText)
        {
            Console.Write(symbol);
        }
        Console.WriteLine();
    }
}
