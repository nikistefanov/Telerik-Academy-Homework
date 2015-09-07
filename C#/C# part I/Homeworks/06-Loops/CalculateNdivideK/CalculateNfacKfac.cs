//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

class CalculateNfacKfac
{
    static void Main()
    {
        Console.Title = "Factorial madness (second edition)!";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Oh! Enter N(it should be less than 100): ");
        int n = int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Oh bitte! Now enter K(should be greater than 1 and less than N): ");
        int k = int.Parse(Console.ReadLine());
        Console.ResetColor();

        int factorialN = 1;
        int factorialK = 1;
        int sum = 1;
        if (k > 1 && k < n && n < 100)
        {
            for (int i = 1, j = 1; i <= n; i++, j++)
            {
                if (j > k)
                {
                    factorialN *= i;
                    sum = factorialN / factorialK;
                }
                else
                {
                    factorialN *= i;
                    factorialK *= j;
                    sum = factorialN / factorialK;
                }
            }
            Console.WriteLine("And N! / K! is {0}", sum);
        }
        else
        {
            Console.WriteLine("We shall not play anymore!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Why? Cuz of this ==> (1 < K < N < 100)");
            Console.ResetColor();
        }
        
    }
}
