//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Linq;

class AppearNumber
{
    static void AppearanceCounter(int[] arrOfNums, int search)
    {
        int counter = 0;
        for (int i = 0; i < arrOfNums.Length; i++)
        {
            if (search == arrOfNums[i])
            {
                counter++;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("Number {0} is not found!", search);
        }
        else
        {
            Console.WriteLine("Number {0} is found {1} times!", search, counter);
        }
    }

    static void Main()
    {
        //int[] arrayOfNumbers = { 2, 5, 5, 6, 8, 4, 9, 8, 4, 5, 3, 1, 2, 5, 7, 9, 8, 1, 2, 6 };

        char[] separators = {',', '.', ' ','\t', '\n'};
        Console.Write("Enter numbers separated by space[ship]: ");
        int[] arrayOfNumbers = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
        Console.Write("Enter the number you are looking for: ");
        int searchedNum = int.Parse(Console.ReadLine());


        Array.Sort(arrayOfNumbers);
        Console.WriteLine(string.Join(", ", arrayOfNumbers));
        AppearanceCounter(arrayOfNumbers, searchedNum);
    }
}