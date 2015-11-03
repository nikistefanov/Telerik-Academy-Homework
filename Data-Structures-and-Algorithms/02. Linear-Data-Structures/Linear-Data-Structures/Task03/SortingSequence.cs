namespace Task03
{
    using System;
    using System.Collections.Generic;

    class SortingSequence
    {
        static void Main()
        {
            // Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.

            var numbers = new List<int>();
            Console.WriteLine("Enter a number: ");
            while (true)
            {
                var userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    break;
                }

                int number = 0;
                var isValidNumber = int.TryParse(userInput, out number);

                if (isValidNumber)
                {
                    numbers.Add(number);
                    Console.WriteLine("Enter another numebr: ");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            Console.WriteLine("Sorting....");
            numbers.Sort();
            Console.WriteLine("Sorted: ");
            numbers.ForEach(x => Console.Write(x + " "));            
        }
    }
}
