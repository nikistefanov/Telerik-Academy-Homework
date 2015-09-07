//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

//input	output
//aaaaabbbbbcdddeeeedssaa	abcdedsa

using System;

class SortLetters
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaa";

        //Console.WriteLine("Please, enter text here: ");
        //string input = Console.ReadLine();

        string result = string.Empty;
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                continue;
            }
            else 
            {
                result += input[i];
            }
        }
        Console.WriteLine(result + input[input.Length - 1]);
    }
}
