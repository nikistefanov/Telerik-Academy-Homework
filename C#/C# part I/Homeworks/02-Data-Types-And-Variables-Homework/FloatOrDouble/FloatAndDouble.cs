//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatAndDouble
{
    static void Main()
    {
        float firstVar = 12.345f;
        float secondVar = 3456.091f;
        double thirdVar = 8923.1234857;
        double fourthVar = 34.567839023;

        Console.WriteLine(" 1.Float = {0}\n 2.Float = {1}\n 3.Double = {2}\n 4.Double = {3}\n", firstVar, secondVar, thirdVar, fourthVar);
    }
}