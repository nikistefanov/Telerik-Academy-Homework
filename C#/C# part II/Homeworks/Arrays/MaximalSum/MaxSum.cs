//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
using System.Linq;

class MaxSum
{
    static void Main()
    {
        Console.Write("Please, enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        double[] arrayOfNumbers = new double[n];
        Console.Write("How many elements you want to be summed: ");
        int k = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine("No point of looking for sum...");
        }
        else
        {
            //initializing each element of the array using input from user
            for (int index = 0; index < arrayOfNumbers.Length; index++)
            {
                Console.Write("Enter value for index[{0}]: ", index);
                double number = double.Parse(Console.ReadLine());
                arrayOfNumbers[index] = number;
            }
            //sorting the array elements from low to high
            Array.Sort(arrayOfNumbers);
            //Console.WriteLine(String.Join(", ", arrayOfNumbers).ToArray());
            double sum = 0;
            for (int i = arrayOfNumbers.Length - 1, j = 1; j <= k; i--, j++)
            {
                sum += arrayOfNumbers[i];
            }
            //print the sum
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("The maximal sum of {0} elements in this array is {1:F2}.", k, sum);
            //Console.WriteLine("Maximal sum for this array is from index[{0}] + index[{1}] = {2} ", firstNumber, secondNumber, sum);
            Console.WriteLine(new string('-', 40));
        }
    }
}




