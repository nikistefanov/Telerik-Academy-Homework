//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class FibonacciGallinacci
{
    static void Main()
    {
        Console.Write("Enter the limit of the Fibonacci-Gallinacci sequnce: ");
        uint limit = uint.Parse(Console.ReadLine());
        uint f1 = 0;
        uint f2 = 1;
        uint f3 = 0;

        if (limit == 0 || limit == 1)
        {
            Console.WriteLine(f1);
        }
        else
        {
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (int i = 2; i < limit; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                Console.WriteLine(f3);
            }
        }       
    }
}