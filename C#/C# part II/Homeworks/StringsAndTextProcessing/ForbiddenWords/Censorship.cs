//Problem 9. Forbidden words

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
using System.Text;

class Censorship
{
    static StringBuilder WordReplacer(string[] words, string text)
    {
        var changedText = new StringBuilder(text);
        string censorship = string.Empty;
        for (int i = 0; i < words.Length; i++)
        {
            censorship = new string ('*', words[i].Length);
            changedText.Replace(words[i], censorship);
        }
        return changedText;
    }

    
    static void Main()
    {
        //string[] forbiddenWords = { "PHP", "CLR", "Microsoft", ".NET" };
        //string inputedText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        Console.WriteLine("Enter text: ");
        string inputedText = Console.ReadLine();
        Console.Write("Enter the forbidden words separated by space: ");
        string[] forbiddenWords = Console.ReadLine().Split(' ');

        var result = WordReplacer(forbiddenWords, inputedText).ToString();
        Console.WriteLine(new string('=', 60));
        Console.WriteLine(result);
    }
}
