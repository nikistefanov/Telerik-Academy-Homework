//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:

//input	output
//Peter	Hello, Peter!

using System;

class Greeting
{
    static void PrintHi(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        Console.WriteLine("What's your name?");
        string userName = Console.ReadLine();
        PrintHi(userName);
    }
}