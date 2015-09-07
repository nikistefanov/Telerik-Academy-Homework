//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Linq;

    class ComparingChars
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of your array: ");
            int gap = int.Parse(Console.ReadLine());
            char[] firstArrayOfChars = new char[gap];
            Console.Write("Enter length of your second array: ");
            int gapTwo = int.Parse(Console.ReadLine());
            char[] secondArrayOfChars = new char[gapTwo];

            bool isEqual = true;

            if (firstArrayOfChars.Length != secondArrayOfChars.Length)
            {
                Console.WriteLine("Length of the arrays is not equal!");
            }
            else
            {
                Console.WriteLine(new string('*', 45));
                //fill the elements of the first array
                Console.WriteLine("Initializing the elements of the first array!");
                for (int index = 0; index < firstArrayOfChars.Length; index++)
                {
                    Console.Write("Enter character for index[{0}]: ", index);
                    firstArrayOfChars[index] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine(new string('*', 45));
                //fill the elements of the second array
                Console.WriteLine("Initializing the elements of the second array!");
                for (int index = 0; index < secondArrayOfChars.Length; index++)
                {
                    Console.Write("Enter character for index[{0}]: ", index);
                    secondArrayOfChars[index] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine(new string('*', 45));

                //compare the two arrays
                for (int index = 0; index < secondArrayOfChars.Length; index++)
                {
                    if (firstArrayOfChars[index] != secondArrayOfChars[index])
                    {
                        isEqual = false;
                        break;
                    }
                }
                if (isEqual)
                {
                    Console.WriteLine("They are equal!");
                }
                else
                {
                    Console.WriteLine("Arrays are not equal!");
                }
            }
        }
    }