//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Text;

class KeyWordExtract
{
    static void ExtractingSentancesWithKeyWord(string text, string keyWord)
    {
        string searchedText = " " + keyWord + " ";
        string[] sentences = text.Split('.');

        int count = 0;
        StringBuilder result = new StringBuilder();
        foreach (var item in sentences)
        {
            int index = item.IndexOf(searchedText, 0);
            while (index != -1)
            {
                index = item.IndexOf(searchedText, index + 1);
                result.Append(item + ".");
                count++;
                break;
            }
        }
        var finalText = result.ToString();
        if (count == 0)
        {
            Console.WriteLine(@"There is no sentances that contains ""{0}""", keyWord);
        }
        else
        {
            Console.WriteLine(@"""{0}"" can be found in {1} sentances.", keyWord, count);
            Console.WriteLine(@"""{0}""", finalText);
        }
    }
    
    static void Main(string[] args)
    {
        //string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        //string searchedText = " in ";
        
        Console.WriteLine("Enter text here, bitte.");
        string inputedText = Console.ReadLine();
        Console.Write("Please, enter the key word: ");
        string inputedKeyWord = Console.ReadLine().Trim();

        ExtractingSentancesWithKeyWord(inputedText, inputedKeyWord);
    }
}
