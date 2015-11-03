namespace Task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Sequence
    {
        static void Main()
        {
            // Write a program that reads from the console a sequence of positive integer numbers.
            // The sequence ends when empty line is entered.
            // Calculate and print the sum and average of the elements of the sequence.
            // Keep the sequence in List<int>.

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
                    Console.WriteLine("Enter a number:");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            Console.WriteLine("Average of the numbers is: " + numbers.Average());
            Console.WriteLine("The sum of the numbers is: " + numbers.Sum());
        }
    }
}
