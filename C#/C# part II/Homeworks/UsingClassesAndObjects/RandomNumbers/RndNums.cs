//Problem 2. Random numbers

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RndNums
{
    static void Main()
    {
        Random rndGenerator = new Random();
        int number = 0;
        for (int i = 0; i < 10; i++)
        {
            number = rndGenerator.Next(100, 201);
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
