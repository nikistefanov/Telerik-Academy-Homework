//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;
using System.Threading;
using System.Globalization;

class SortNumbers
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

        if (a == b && b == c)
        {
            Console.WriteLine(a + " " + b + " " + c);
        }
        else if (a >= b && a >= c)
        {
            Console.Write(a + " ");
            if (b >= c)
            {
                Console.WriteLine(b + " " + c);
            }
            else
            {
                Console.WriteLine(c + " " + b);
            }
        }
        else if (b >= a && b >= c)
        {
            Console.Write(b + " ");
            if (a >= c)
            {
                Console.WriteLine(a + " " + c);
            }
            else
            {
                Console.WriteLine(c + " " + a);
            }
        }
        else if (c >= a && c >= b)
        {
            Console.Write(c + " ");
            if (a >= b)
            {
                Console.WriteLine(a + " " + b);
            }
            else
            {
                Console.WriteLine(b + " " + a);
            }
        }
    }
}
