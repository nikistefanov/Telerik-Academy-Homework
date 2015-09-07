//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;

class SubText
{
    static void Main()
    {
        Console.WriteLine("Enter text here, bitte.");
        string text = Console.ReadLine();
        Console.Write("What are you looking for: ");
        string searchedText = Console.ReadLine();

        int counter = 0;
        int index = text.IndexOf(searchedText, 0);

        while (index != -1)
        {
            counter++;
            index = text.IndexOf(searchedText, index + 1);
            
        }
        Console.WriteLine("{0} is found {1} times in this text.", searchedText, counter);
    }
}