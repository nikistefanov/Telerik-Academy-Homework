//Code 3-6-9
//3     4
//6     12
//4

//9     1
//9     4
//5	

using System;


class UsingIf
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());

        long result = 0;

        if (b == 3)
        {
            result = a + c;
        }
        else if (b == 6)
        {
            result = a * c;
        }
        else if (b == 9)
        {
            result = a % c;
        }

        long secondResult = 0;

        if (result % 3 == 0)
        {
            secondResult = result / 3;
        }
        else
        {
            secondResult = result % 3;
        }

        Console.WriteLine(secondResult);
        Console.WriteLine(result);
    }
}