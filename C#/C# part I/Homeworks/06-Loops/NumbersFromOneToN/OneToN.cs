//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;

class OneToN
{
    static void Main()
    {
        Console.Write("Please, enter a positive number: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Ooohh sorry! Positive number, you know? + ");
            return;
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
