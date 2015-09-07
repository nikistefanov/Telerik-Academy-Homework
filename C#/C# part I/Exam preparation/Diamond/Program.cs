using System;

class Program
{
    static void Main(string[] args)
    {
        //   first part
        //   ...*****...
        //   second
        //   ..*..*..*..
        //   .*...*...*.
        //   third
        //   ***********
        //   fourth
        //   .*...*...*.
        //   ..*..*..*..
        //   ...*.*.*...
        //   ....***....
        //   fifth
        //   .....*.....


        //int N = int.Parse(Console.ReadLine());
        int N = 7;

        int widt = N * 2 + 1;
        int height = 6 + ((N - 3) / 2) * 3;

        int topDots = (widt - N) / 2; // example with N = 5 --> will print 3 dots.

        //first part
        //...*****...

        Console.Write(new string('.', topDots));
        Console.Write(new string('*', N));
        Console.WriteLine(new string('.', topDots));

        int nextDots = topDots - 1;
        int topRows = topDots;

        //second
        //..*..*..*..
        //.*...*...*.

        for (int i = 0; i < topRows - 1; i++)
        {
            topDots--;
            Console.Write(new string('.', topDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.WriteLine(new string('.', topDots));

            nextDots++;
        }
        //   third
        //   ***********

        Console.WriteLine(new string('*', widt));

        //   fourth
        //   .*...*...*.
        //   ..*..*..*..
        //   ...*.*.*...
        //   ....***....

        int firstDots = 1;
        for (int i = 0; i < N - 1; i++)
        {
            nextDots--;
            Console.Write(new string('.', firstDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.Write(new string('.', nextDots));
            Console.Write('*');
            Console.WriteLine(new string('.', firstDots));
            firstDots++;
        }

        //   fifth
        //   .....*.....
        Console.Write(new string('.', N));
        Console.Write('*');
        Console.WriteLine(new string('.', N));
    }
}