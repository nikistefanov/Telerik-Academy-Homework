//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input	output
//Hi!	\u0048\u0069\u0021

using System;
using System.Text;

class StringToUnicode
{
    static void Main()
    {
        Console.Write("Enter text, bitte: ");
        string text = Console.ReadLine();
        StringBuilder result = new StringBuilder(); 
        foreach (var symbol in text)
        {
            result.Append(@"\u");
            result.Append(String.Format("{0:x4}", (int)symbol));
        }
        Console.WriteLine(result.ToString());
    }
}