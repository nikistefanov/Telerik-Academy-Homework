//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

class Combinatoric
{
    static void Main()
    {
        Console.Write("Yet again...enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Do the same for K = ");
        int k = int.Parse(Console.ReadLine());
        
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger facNK = 1; ;
        if (k > 1 && k < n && n < 100)
        {
            for (int i = 1, j = 1; i <= n; i++, j++)
            {
                if (j > k)
                {
                    factorialN *= i;
                }
                else
                {
                    factorialN *= i;
                    factorialK *= j;
                }
            }
            for (int i = 1; i <= (n - k); i++)
            {
                facNK *= i;
            }
            Console.WriteLine(factorialN / (factorialK * facNK));
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorry the numbers must be like this => (1 < K < N < 100)");
            Console.ResetColor();
        }
    }
}
