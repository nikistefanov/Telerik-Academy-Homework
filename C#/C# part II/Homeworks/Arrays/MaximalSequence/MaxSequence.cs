//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Linq;

class MaxSequence
{
    static void Main()
    {
        Console.Write("Please, enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];
        if (n == 1)
        {
            Console.WriteLine("No point of looking for sequence...");
        }
        else
        {
            //initializing each element of the array using input from user
            for (int index = 0; index < arrayOfNumbers.Length; index++)
            {
                Console.Write("Enter value for index[{0}]: ", index);
                int number = int.Parse(Console.ReadLine());
                arrayOfNumbers[index] = number;
            }

            // //initializing each element of the array using random numbers
            //Random r = new Random();
            //Console.WriteLine("Random numbers!");
            //Console.WriteLine(new string('-', 40));
            //for (int i = 0; i < arrayOfNumbers.Length; i++)
            //{
            //
            //    int number = r.Next(1, 5);
            //    //Console.Write(number + " | ");
            //    arrayOfNumbers[i] = number;
            //    Console.Write(arrayOfNumbers[i] + " # ");
            //}

            int bestSequence = 0;
            int bestNumber = 0;
            int startLength = 0;
            int currentNumber = arrayOfNumbers[1];

            //check for the lognest sequence
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] == currentNumber)
                {
                    startLength++;
                }
                else
                {
                    currentNumber = arrayOfNumbers[i];
                    startLength = 1;
                }

                if (startLength >= bestSequence)
                {
                    bestSequence = startLength;
                    bestNumber = currentNumber;
                }
            }
            //print the sequence
            Console.WriteLine();
            Console.WriteLine(new string('-', 40));
            Console.Write("The best sequence is: ");
            for (int i = 0; i < bestSequence; i++)
            {
                if (i != bestSequence - 1)
                {
                    Console.Write(bestNumber + ", ");
                }
                else
                {
                    Console.WriteLine(bestNumber);
                }
            }
        }
    }
}




