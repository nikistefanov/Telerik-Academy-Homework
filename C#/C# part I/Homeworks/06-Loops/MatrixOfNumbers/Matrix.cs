//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

using System;

class Matrix
{
    static void Main()
    {
        Console.Title = "Blue pill or Red pill?";
        Console.Write("Enter a number (1 ≤ N ≤ 20):  ");
        int n = int.Parse(Console.ReadLine());

        if (1 <= n && n <= 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < n + row; col++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("The number must be between 1 and 20!");
        }
        
    }
}
