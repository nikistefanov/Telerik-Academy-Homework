namespace Task02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Reverser
    {
        static void Main()
        {
            // Write a program that reads N integers from the console and reverses them using a stack.
            // Use the Stack<int> class.

            var numbers = new Stack<string>();

            Console.WriteLine("Please enter numbers separated by [space]: ");
            var userInput = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < userInput.Length; i++)
            {
                numbers.Push(userInput[i]);
            }

            Console.WriteLine("In reverse: ");

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.Write(numbers.Pop() + " ");
            }
        }
    }
}
