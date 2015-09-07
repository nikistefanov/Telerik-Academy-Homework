//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;

class ExtractingEmails
{
    static void Main()
    {
        string text = @"This is an automated message -- please do not reply at noreply@muhama.com, if you want to ask something write us at outdoors@relax.com or pickaboo@home.net, bye.";
        string[] words = text.Split(' ', ',');
        List<string> emails = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains("@"))
            {
                if (words[i].Contains("."))
                {
                    if (words[i].IndexOf('@') < words[i].IndexOf('.'))
                    {
                        emails.Add(words[i]);
                    }
                }
            }
        }
        foreach (var mail in emails)
        {
            Console.WriteLine(mail);
        }
    }
}
