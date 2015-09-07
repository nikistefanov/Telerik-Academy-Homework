/*Problem 5. 64 Bit array
Define a class BitArray64 to hold 64 bit values inside an ulong value.
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.*/

namespace PrebitArray
{
    using System;

    class StartPoint
    {
        static void Main()
        {
            BitArray firstNumber = new BitArray(1151351);
            BitArray secondNumber = new BitArray(5);
            Console.Write("Number {0} as bits: ", firstNumber.GetHashCode());
            Console.WriteLine(String.Join("", firstNumber));
            Console.Write("Number {0} as bits: ", secondNumber.GetHashCode());
            Console.WriteLine(String.Join("", secondNumber));

            Console.Write("Index[0]: ");
            Console.WriteLine(firstNumber[0]);
            firstNumber[3] = 1;

            Console.Write("Are they equal (using ==): ");
            Console.WriteLine(firstNumber == secondNumber);

            Console.Write("Are they equal (using .Equals()): ");
            Console.WriteLine(firstNumber.Equals(secondNumber));

            Console.WriteLine("Foreaching...");
            foreach (var item in firstNumber)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Console.WriteLine("Hash code of first number is: {0}", firstNumber.GetHashCode());
            Console.WriteLine("Hash code of second number is: {0}", secondNumber.GetHashCode());
        }
    }
}
