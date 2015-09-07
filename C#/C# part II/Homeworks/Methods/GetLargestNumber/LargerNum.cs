//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class LargerNum
{
    static int GetMax(int fNum, int sNum)
    {
        if (fNum > sNum)
        {
            return fNum;
        }
        else
        {
            return sNum;
        }
    }

    static void Main()
    {
        Console.Write("First number = ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number = ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Third number = ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("The greater number is ");
        Console.WriteLine(GetMax(GetMax(firstNumber, secondNumber), thirdNumber));
    }
}
