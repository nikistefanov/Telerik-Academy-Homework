//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.


using System;

class ExchangeGreater
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        double c = 0;

        if (a > b)
        {
            c = a;
            a = b;
            b = c;

            Console.WriteLine("Exchanging values....:{0} {1}", a, b);
        }
        else if (a == b)
        {
            Console.WriteLine("Oh boy! They are equal! See! {0} = {1}", a, b);
        }
        else
        {
            Console.WriteLine("Yeap, no exchanging needed...{0} {1}", a, b);
        }
    }
}