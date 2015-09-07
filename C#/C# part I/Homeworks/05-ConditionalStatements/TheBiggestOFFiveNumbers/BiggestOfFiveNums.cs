//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Threading;
using System.Globalization;

class BiggestOfFiveNums
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d= ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e= ");
        double e = double.Parse(Console.ReadLine());

        double max = a;

        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        if (d > max)
        {
            max = d;
        }
        if (e > max)
        {
            max = e;
        }
        Console.WriteLine("The biggest of them is {0}", max);
    }
}