//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;
using System.Globalization;

class DifferenceOfDates
{
    static void Main()
    {
        try
        {
            Console.Write("Please enter date in format: day.month.year: ");
            var firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.GetCultureInfo("bg-BG"));
            Console.Write("Please enter another date in the same format: ");
            var secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.GetCultureInfo("bg-BG"));
            Console.WriteLine("The difference between these dates is {0} days.", Math.Abs((firstDate - secondDate).TotalDays));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Please, enter the date in a valid format, like the one in the example!\n" + ex); ;
        }
    }
}
