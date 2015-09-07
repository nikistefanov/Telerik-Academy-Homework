//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Linq;

class CompareToNeighbours
{
    static void Main()
    {
        char[] separators = { ',', '.', ' ', '\t', '\n' };
        Console.Write("Enter numbers separated by space[ship]: ");
        int[] arrayOfNumbers = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
        Console.Write("Which index of the array you want to compare: ");
        byte numberToCompare = byte.Parse(Console.ReadLine());
        switch (CompareElements(arrayOfNumbers, numberToCompare))
        {
            case -1: Console.WriteLine("Index[{0}] is NOT greater than its two neighbours."); break;
            case 0: Console.WriteLine("Index[{0}] has only one neighbour."); break;
            case 1: Console.WriteLine("Index[{0}] is GREATER than its two neighbours."); break;
            default: Console.WriteLine("Error");
                break;
        }
    }

    static int CompareElements(int[] array, int postition = 0)
    {
        int result = -1;
        if ((array[postition] == array[0]) || (array[postition] == array[array.Length - 1]))
        {
            result = 0;
        }
        else
        {
            if ((array[postition - 1] < array[postition]) && (array[postition] > array[postition + 1]))
            {
                result = 1;
            }
        }
        return result;
    }
}
