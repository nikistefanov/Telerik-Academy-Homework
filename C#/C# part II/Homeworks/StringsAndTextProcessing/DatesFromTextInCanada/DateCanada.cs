//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Threading;


class DateCanada
{
    static void Main(string[] args)
    {
        string text = @"Grand Theft Auto 5's PC release date has been knocked a couple of months into the future from 28.02.2015 to 24.03.2015 and we are still waiting from 2014.";
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            try
            {
                DateTime date = DateTime.ParseExact(words[i], "d.M.yyyy",
                CultureInfo.InvariantCulture);
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                Console.WriteLine(date.Date.ToLongDateString());
            }
            catch
            {
            }
        }
    }
}
