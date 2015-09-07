﻿//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class FactorialSum
{
    static void Main(string[] args)
    {
        Console.Title = "Factorial madness!";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Oh yes! Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Oh yes! Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.ResetColor();

        double factorial = 1;
        double power = 1;
        double sum = 1; ;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power *= x;
            sum = sum + (factorial / power);
        }
        Console.WriteLine("Blah this was not amusing...just saying.");
        Console.WriteLine("And the sum is ---> {0:F5}", sum);
    }
}