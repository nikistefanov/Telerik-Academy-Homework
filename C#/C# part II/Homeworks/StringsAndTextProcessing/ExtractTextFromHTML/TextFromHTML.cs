//Problem 25. Extract text from HTML

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:

//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>
//Output:

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.

using System;
using System.Text;

class TextFromHTML
{
    static void Main()
    {
        string textHTML = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body> </html>";
        string title = string.Empty;

        if (textHTML.Contains("<title>"))
        {
            int startIndex = textHTML.IndexOf("<title>") + 7;
            int endIndex = textHTML.IndexOf("</title>");
            title = textHTML.Substring(startIndex, endIndex - startIndex);
            textHTML = textHTML.Substring(endIndex + 8);
        }

        string result = RemoveTags(textHTML).Replace("</a>", " ").ToString();
        if (title != string.Empty)
        {
            Console.WriteLine(title);
        }

        Console.WriteLine(result);
    }

    static StringBuilder RemoveTags(string someText)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(someText);
        while (sb.ToString().Contains("<") || sb.ToString().Contains(">"))
        {
            int start = sb.ToString().IndexOf("<");
            int end = sb.ToString().IndexOf(">");
            sb.Remove(start, end - start + 1);
        }
        return sb;
    }
}
