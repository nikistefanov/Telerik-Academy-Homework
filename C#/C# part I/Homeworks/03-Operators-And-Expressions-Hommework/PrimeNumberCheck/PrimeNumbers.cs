//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeNumbers
{
    static void Main()
    {

        Console.Write("Enter a positive number that is equal or less than 100: ");
        int number = int.Parse(Console.ReadLine());
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(number);
        bool prime = true;
        if (number < 0)
        {
            Console.Write("Enter a positive number: ");
            number = int.Parse(Console.ReadLine());
        }
        while (prime && (divider <= maxDivider))
        {
            if (number % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        Console.WriteLine(number +" ---> " + prime);

    }
}