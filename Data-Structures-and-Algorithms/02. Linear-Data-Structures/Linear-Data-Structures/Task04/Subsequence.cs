namespace Task04
{
    using System.Collections.Generic;

    class Subsequence
    {
        static void Main()
        {
            // Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.

            var numbers = new List<int>() { 1, 1, 1, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 6, 6, 6, 7, 7 };

            var resultNumber = numbers[0];
            var currentNumber = numbers[0];
            var mostOccurances = 0;
            var currentOccurances = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == currentNumber)
                {
                    currentOccurances += 1;
                }
                else
                {
                    if (currentOccurances > mostOccurances)
                    {
                        mostOccurances = currentOccurances;
                        resultNumber = currentNumber;

                        currentOccurances = 1;
                    }
                }

                currentNumber = numbers[i];
            }

            var isPlural = mostOccurances > 1 ? "times" : "time";
            System.Console.WriteLine("Number {0} found {1} {2}.", resultNumber, mostOccurances, isPlural);
        }
    }
}
