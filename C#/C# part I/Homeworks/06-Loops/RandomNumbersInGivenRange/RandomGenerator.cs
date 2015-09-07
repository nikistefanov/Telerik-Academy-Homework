//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomGenerator
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Max = ");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        if (min != max && min < max)
        {
            for (int i = 0; i < n; i++)
            {
                int number = rnd.Next(min, max + 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Min value must be less than Max value (not equal too)!");
        }
        Console.ResetColor();
    }
}
