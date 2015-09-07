//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;
using System.Threading;
using System.Globalization;

class BiggestOfThreeNums
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

        double max = a;

        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        Console.WriteLine("The biggest of them is {0}", max);
    }
}
