//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class HavingFuunWithNumbers
{
    static void Main()
    {
        Console.Write("With how many number you what to play? ");
        int nInput = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;
        double average = 0;
        
        if (nInput < 0)
        {
            Console.WriteLine("Ooohh sorry! Positive number, you know? + ");
            return;
        }
        else
        {
            for (int i = 0; i < nInput; i++)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                else if (number < min)
                {
                    min = number;
                }
                sum += number;
            }
            average = sum / nInput;
            Console.WriteLine(@"
max = {0}
min = {1}
sum = {2}
average = {3:F2}", max, min, sum, average);
        }
    }
}