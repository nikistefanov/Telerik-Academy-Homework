//Problem 9. Sorting array

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

class SortArray
{
    static void Main()
    {
        char[] separators = { ',', '.', ' ', '\t', '\n' };
        Console.Write("Enter numbers separated by space[ship]: ");
        int[] arrayOfNumbers = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

        Console.WriteLine("Enter a number between 0 and {0}", arrayOfNumbers.Length - 1);
        int startingIndex = int.Parse(Console.ReadLine());


        Console.WriteLine("maximal element in a portion of array of integers starting at index[{0}]  is {1}", startingIndex, MaxElement(arrayOfNumbers, startingIndex));
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", AscendingOrder(arrayOfNumbers)));
        Console.WriteLine(string.Join(" ", DescendingOrder(arrayOfNumbers)));

    }
    static int MaxElement(int[] array, int indexInArray)
    {
        int number = 0;

        for (int i = indexInArray; i < array.Length; i++)
        {
            if (number < array[i])
            {
                number = array[i];
            }
        }
        return number;
    }

    static int[] DescendingOrder(int[] array)
    {
        Array.Sort(array);
        return array;
    }
    static int[] AscendingOrder(int[] array)
    {
        Array.Reverse(DescendingOrder(array));
        return array;
    }

}
