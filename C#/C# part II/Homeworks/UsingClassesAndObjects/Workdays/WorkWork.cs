//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class WorkWork
{
    static DateTime[] holidays =
    {
            new DateTime(2015, 1, 1), new DateTime(2015, 1, 2), new DateTime(2015, 3, 2), 
            new DateTime(2015, 3, 3),new DateTime(2015, 4, 10), new DateTime(2015, 4, 13), 
            new DateTime(2015, 5, 1), new DateTime(2015, 5, 6), new DateTime(2015, 9, 21), 
            new DateTime(2015, 9, 22), new DateTime(2015, 12, 24), new DateTime(2015, 12, 25), new DateTime(2015, 12, 31)

    };
    static  DateTime[] workingWeekends =
	{
		new DateTime(2015, 1, 24), new DateTime(2015, 3, 21), new DateTime(2015, 9, 12),
		new DateTime(2015, 12, 12)
	};


    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        char[] separators = { ',', '.', ' ', '\t', '\n', '\\', '/' };
        Console.WriteLine("Today is {0: dd.MM.yyyy}", DateTime.Now);
        DateTime today = DateTime.Now;
        Console.WriteLine("Enter a date between today and the end of year {0}.", DateTime.Now.Year);
        int[] dateToInt = Console.ReadLine().Split(separators).Select(int.Parse).ToArray();
        var futureDate = new DateTime(dateToInt[2], dateToInt[1], dateToInt[0]);
        Console.WriteLine("There are {0} working days until {1: dd.MM.yyyy}", CalculateWorkingdays(today, futureDate), futureDate.Date);
    }

    static int CalculateWorkingdays(DateTime todayDate, DateTime givenDate)
    {
        int countDays = 0;

        if (todayDate > givenDate)
        {
            DateTime temp = todayDate;
            todayDate = givenDate;
            givenDate = temp;
        }

        while (todayDate <= givenDate)
        {
            if (!holidays.Contains(todayDate)
            && !workingWeekends.Contains(todayDate)
            && todayDate.DayOfWeek != DayOfWeek.Saturday
            && todayDate.DayOfWeek != DayOfWeek.Sunday)
            {
                countDays++;
            }
            todayDate = todayDate.AddDays(1);
        }

        return countDays;
    }
}