//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;

class TextFill
{
    static void PrintTextOptions(string text)
    {
        if (text.Length == 20)
        {
            Console.WriteLine(text);
        }
        else if (text.Length < 20)
        {
            int charsToFillCount = 20 - text.Length;
            string star = new string('*', charsToFillCount);
            Console.WriteLine(text + star);
        }
        else
        {
            string result = text.Substring(0, 20);
            Console.WriteLine(result);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter text here: ");
        string inputedText = Console.ReadLine();

        PrintTextOptions(inputedText);
    }
}
