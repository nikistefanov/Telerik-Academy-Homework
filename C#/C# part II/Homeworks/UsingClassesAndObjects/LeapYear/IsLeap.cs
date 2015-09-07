//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class IsLeap
{
    static void Main()
    {
        Console.Write("Please enter year to check: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        if (year >= DateTime.Now.Year)
        {
            if (isLeap == true) Console.WriteLine("{0} is a leap year", year);
            else Console.WriteLine("{0} is NOT a leap year", year);
        }
        else
        {
            if (isLeap == true) Console.WriteLine("{0} was a leap year", year);
            else Console.WriteLine("{0} was NOT a leap year", year);
        }
    }
}
