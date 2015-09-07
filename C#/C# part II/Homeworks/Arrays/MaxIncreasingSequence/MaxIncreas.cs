//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Linq;

class MaxIncreas
{
    static void Main()
    {
        Console.Write("Please, enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];
        if (n == 1)
	    {
                Console.WriteLine("No point of looking for sequence!");
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
            //for (int i = 0; i < arrayOfNumbers.Length; i++)
            //{
            //    
            //    int number = r.Next(1, 5);
            //    //Console.Write(number + " | ");
            //    arrayOfNumbers[i] = number;
            //    Console.Write(arrayOfNumbers[i] + " # ");
            //}

            int bestSequence = 0;
            int startLength = 1;
            int currentNumber = arrayOfNumbers[0];
            int bestNumber = currentNumber;

            //check for the lognest sequence
            if (arrayOfNumbers.Length == 1)
            {
                bestNumber = currentNumber;
                bestSequence = 1;
                return;
            }

            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i - 1] == arrayOfNumbers[i] - 1)
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
            Console.Write("The best increasing sequence is: ");
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
                //Console.Write(i != bestSequence - 1 ? bestNumber + ", " : bestNumber + "\n");
                bestNumber++;
            }
        }
    }
}