//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class NumbersNumbers
{
    static int numbersLeft = 10;

    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter two numbers between 1 and 100 so we can use them for start and end points.");
            Console.Write("Start number = ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("End number = ");
            int endNumber = int.Parse(Console.ReadLine());

            int[] arrayOfNumbers = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                if (i == 10) Console.Write("Enter {0} more number that is greater than {1} --> ", numbersLeft, startNumber);
                else Console.Write("Enter {0} more numbers that are greater than {1} --> ", numbersLeft, startNumber);
                arrayOfNumbers[i] = ReadNumber(startNumber, endNumber);
                startNumber = arrayOfNumbers[i];
                numbersLeft--;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer!");
        }

    }

    private static int ReadNumber(int start, int end)
    {
        try
        {
            int numberEntered = int.Parse(Console.ReadLine());
            if (numberEntered <= start || numberEntered >= end)
            {
                throw new ArgumentOutOfRangeException();
            }

            return numberEntered;
        }
        catch (FormatException fe)
        {
            throw new Exception("Please, enter a valid number! " + fe.Message);
        }
        catch (ArgumentOutOfRangeException ae)
        {
            throw new Exception("Number must be larger than the previous! " + ae.Message);
        }

    }
}