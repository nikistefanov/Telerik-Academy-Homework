//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

class Catalans
{
    static void Main(string[] args)
    {
        Console.Write("I hope this is the last time using factorial numbers...enter N = ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factN = 1;
        BigInteger fact2N = 1;
        BigInteger factNPlus1 = 1;

        if (0 <= n && n <= 100)
        {
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }
            for (int j = 1; j <= 2 * n; j++)
            {
                fact2N *= j;
            }
            for (int k = 1; k <= n + 1; k++)
            {
                factNPlus1 *= k;
            }
            Console.WriteLine(fact2N / (factNPlus1 * factN));
        }
        else
        {
            Console.WriteLine("The number must be between 0 and 100.");
        }
        
    }
}
