//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class ComparingArray
{
    static void Main()
    {
        Console.Write("Enter the length of the first array: ");
        int fNum = int.Parse(Console.ReadLine());
        int[] firstArray = new int[fNum];
        Console.Write("Enter the length of the second array: ");
        int sNum = int.Parse(Console.ReadLine());
        int[] secondArray = new int[sNum];
        bool isEqual = true;

        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("The length of the arrays are not equal!");
        }
        else
        {
            Console.WriteLine(new string('*', 40));
            //initializing each element of the first array
            Console.WriteLine("Elements of first array.");
            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.Write("Enter value for index[{0}]: ", index);
                int number = int.Parse(Console.ReadLine());
                firstArray[index] = number;
            }
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Elements of second array.");
            //initializing each element of the second array
            for (int index = 0; index < secondArray.Length; index++)
            {
                Console.Write("Enter value for index[{0}]: ", index);
                int number = int.Parse(Console.ReadLine());
                secondArray[index] = number;
            }
            Console.WriteLine(new string('*', 40));
            //checking if the elements of the arrays are equal
            for (int index = 0; index < secondArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    isEqual = false;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("Elements are equal!"); 
            }
            else
            {
                Console.WriteLine("Elements of the arrays are not equal!");
            }
        }
    }
}