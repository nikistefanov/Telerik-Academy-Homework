//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValues
{
    static void Main()
    {
        int? firstValue = null;
        double? secondValue = null;
        Console.WriteLine("At first the value of the integer is: {0}", firstValue);
        Console.WriteLine("At first the value of the double is: {0}", secondValue);
        Console.WriteLine(new string ('*', 40));

        firstValue += 15;
        secondValue += 6587.457;
        Console.WriteLine("Now trying to add 15 to the integer -> value: {0}", firstValue);
        Console.WriteLine("Now trying to add some 6587.457 to of the double -> value: {0}", secondValue);
        Console.WriteLine(new string('*', 40));

        
        Console.WriteLine("And adding values using \"GetValueOrDefault()\"! ");
        Console.WriteLine("Integer is: {0}", firstValue.GetValueOrDefault() + 15);
        Console.WriteLine("Double is: {0}", secondValue.GetValueOrDefault() + 6587.457);
        Console.WriteLine(new string('*', 40));


       

    }
}
