//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOfFive
{
    static void Main()
    {
        Console.Write("Enter 5 numbers(separated by a space[ship]: ");
        string[] text = Console.ReadLine().Split(' ');
        double sum = 0;
        
        for (int i = 0; i < text.Length; i++)
        {
            sum += Convert.ToDouble(text[i]);
        }
        Console.WriteLine(sum);
    }
}