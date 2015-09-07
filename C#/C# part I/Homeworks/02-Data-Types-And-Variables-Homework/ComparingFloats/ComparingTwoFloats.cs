//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class ComparingTwoFloats
{
    static void Main()
    {
        Console.WriteLine("Write the first number: ");
        double fNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Write the second number: ");
        double sNum = double.Parse(Console.ReadLine());

        bool equal = Math.Abs(fNum - sNum) < 0.000001;

        Console.WriteLine(equal ? "Yeah they're equal" : "Too big difference!");
    }
}