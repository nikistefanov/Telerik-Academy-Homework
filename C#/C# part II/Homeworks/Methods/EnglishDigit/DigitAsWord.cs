//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	output
//512	two
//1024	four
//12309	nine

using System;

class DigitAsWord
{
    static void ExtractLastDigit(int number)
    {
        string[] numberAsWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eigth", "nine" };
        int digit = number % 10;
        Console.WriteLine("The last digit is {0}!", numberAsWords[digit]);
    }
    
    static void Main()
    {
        Console.Write("Please, enter your number: ");
        int userNumber = int.Parse(Console.ReadLine());
        ExtractLastDigit(userNumber);
    }

    
}