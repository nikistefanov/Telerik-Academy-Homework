//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;

class ParsingSomeTags
{
    static string ReplaceTextInTags(string text, string firstTag)
    {
        int index = text.IndexOf("<upcase>");
        int firstTagLength = firstTag.Length;
        while (index != -1)
        {
            int startingPositonOfTag = text.IndexOf("<upcase>");
            int endingPositionOfTag = text.IndexOf("</upcase>");

            string textToBeReplaced = text.Substring((startingPositonOfTag + firstTagLength), (endingPositionOfTag - startingPositonOfTag - firstTagLength));
            text = text.Replace("<upcase>" + textToBeReplaced + "</upcase>", textToBeReplaced.ToUpper());
            index = text.IndexOf("<upcase>", index + 1);
        }
        return text;
    }

    static void Main()
    {
        Console.WriteLine("Please, enter some text surrounded by tags (<upcase> ... </upcase>).");
        //string inputedText = Console.ReadLine();
        string inputedText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        string openTag = "<upcase>";
        Console.WriteLine(ReplaceTextInTags(inputedText, openTag));


    }
}
