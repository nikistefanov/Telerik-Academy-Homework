//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;
using System.Threading;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Can this number be divided by 7 and 5?");
        Thread.Sleep(2000);

    if (number % 5 == 0 && number % 7 == 0)
	{
		 Console.WriteLine("Yes!");
	}
    else
    {
        Console.WriteLine("No!");
    }
    }
}