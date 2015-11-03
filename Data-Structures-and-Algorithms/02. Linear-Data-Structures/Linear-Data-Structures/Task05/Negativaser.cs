namespace Task05
{
    using System;
    using System.Collections.Generic;

    class Negativaser
    {
        static void Main(string[] args)
        {
            // Write a program that removes from given sequence all negative numbers.

            var numbers = new List<int>() { 1, -1, 10, -2, -3, 13, 32, -23, 6, 44, -54, 134, -244, 25, -63, 6, 686, -77, 27 };

            numbers.RemoveAll(x => x < 0);
            numbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }
    }
}
