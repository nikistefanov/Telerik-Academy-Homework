//Problem 17. Date in Bulgarian

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Linq;
using System.Globalization;
using System.Threading;

class BgDate
{
    static void Main()
    {
        Console.WriteLine("Please enter date in format: day.month.year hour:minute:second");
        try
        {
            var date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy H:mm:ss", CultureInfo.GetCultureInfo("bg-BG"));
            Console.WriteLine("Now with 6h and 30min added:");
            Console.WriteLine("{0} - {0:dddd}", date.AddHours(6).AddMinutes(30));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Please, enter the date in a valid format, like the one in the example!\n" + ex); ;
        }

    }
}