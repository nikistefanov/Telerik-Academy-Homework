using System;

class Program
{
    static void Main(string[] args)
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());

        decimal result = (decimal)a / b + (decimal)c / d;
        if (result >= 1)
        {
            Console.WriteLine((long)result);
        }
        else
        {
            Console.WriteLine("{0:F22}", result);
        }

        Console.WriteLine("{0}/{1}", a * d + c * b, b * d);

    }
}
