//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;

class SumOfN
{
    static void Main()
    {
        Console.Write("Enter how many number you want to sum: ");
        int gap = int.Parse(Console.ReadLine());
        double result = 0;
        string star = new string('*', 40);

        for (int i = 0; i < gap; i++)
        {
            Console.Write("Enter a number, bitte: ");
            result += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(star);
        Console.WriteLine("Aaaand the sum of them is {0}", result);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Splending!");
        Console.ResetColor(); 
    }
}
