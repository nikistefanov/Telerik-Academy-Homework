//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Title = "Hooray odd or even?";
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine(number % 2 == 0 ? "This number is even!" : "This number is odd!");        
    }
}
