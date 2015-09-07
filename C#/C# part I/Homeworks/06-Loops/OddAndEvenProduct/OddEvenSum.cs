//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddEvenSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter numbers(separated by a space[ship]: ");
        string[] numbers = Console.ReadLine().Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= int.Parse(numbers[i]);
            }
            else
            {
                evenProduct *= int.Parse(numbers[i]);
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes!");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("No!");
            Console.WriteLine("odd_product = {0}\t even_product = {1}", oddProduct, evenProduct);
        }
    }
}
