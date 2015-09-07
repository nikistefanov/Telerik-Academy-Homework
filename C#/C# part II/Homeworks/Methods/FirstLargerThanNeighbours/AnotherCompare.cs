//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Linq;

class AnotherCompare
{
    static void Main()
    {
        char[] separators = { ',', '.', ' ', '\t', '\n' };
        Console.Write("Enter numbers separated by space[ship]: ");
        int[] arrayOfNumbers = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

        for (int i = 1; i < arrayOfNumbers.Length - 1; i++)
        {
            if (CompareElements(arrayOfNumbers, i) == 1)
            {
                Console.WriteLine("Index[{0}]", i);
                return;
            }
        }
        Console.WriteLine(CompareElements(arrayOfNumbers));
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
