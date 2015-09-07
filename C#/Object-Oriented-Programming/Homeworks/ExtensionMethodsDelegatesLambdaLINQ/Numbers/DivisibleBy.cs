//Problem 6. Divisible by 7 and 3
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
using System;
using System.Linq;

class DivisibleBy
{
    static void Main()
    {
        //Console.WriteLine("Please enter some integers separed by a [space]!");
        //string numbersAsString = Console.ReadLine();
        string numbersAsString = "1 672 54 63 35 842 3 21 42 76  14 81 252";

        int[] arrayOfNumbers = numbersAsString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        
        var sortedNumbersWithLambda = arrayOfNumbers.Where(number => (number % 7 == 0) && (number % 3 == 0));
        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Using lambda expressions:");
        Console.WriteLine(new string('=', 40));
        Console.WriteLine(string.Join(", ", sortedNumbersWithLambda));

        var sortedNumbersWithLINQ = from number in arrayOfNumbers
                                    where number % 7 == 0 && number % 3 == 0
                                    select number;
        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Using LINQ:");
        Console.WriteLine(new string('=', 40));
        Console.WriteLine(string.Join(", ", sortedNumbersWithLINQ));
    }
}
