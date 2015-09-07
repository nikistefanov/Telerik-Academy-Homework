namespace RefactorLoop
{
    using System;

    class RefactorLoop
    {
        static void Main()
        {
            int[] numbers = new int[] { 5, 89, 52, 34, 3, 13, 22 };
            int expectedValue = 3;
            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == expectedValue)
                {
                    isFound = true;
                    break;
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            // More code here
            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
