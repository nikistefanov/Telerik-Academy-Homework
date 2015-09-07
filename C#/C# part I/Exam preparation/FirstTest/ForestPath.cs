using System;

class ForestPath
{
    static void Main()
    {

//      first
//      *...
//      .*..
//      ..*.
//      ...*
//      second
//      ..*.
//      .*..
//      *...


        int n = int.Parse(Console.ReadLine());

        //      first
        //      *...
        //      .*..
        //      ..*.
        //      ...*
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == j)
                {
                    Console.Write('*');
                }
                else Console.Write('.');
            }
            Console.WriteLine();
        }
        //      second
        //      ..*.
        //      .*..
        //      *...
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == j)
                {
                    Console.Write('*');
                }
                else Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}