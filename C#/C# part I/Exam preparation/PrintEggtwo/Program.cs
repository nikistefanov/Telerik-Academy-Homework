using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        //   1  .......*****.......

        //   2  .....*.......*.....
        //      ...*...........*...
        //      .*...............*.

        //   3  .*...............*.

        //   4  .*.@.@.@.@.@.@.@.*.
        //      .*@.@.@.@.@.@.@.@*.

        //   5  .*...............*.

        //    6 .*...............*.
        //      ...*...........*...
        //      .....*.......*.....

        //    7 .......*****.......

        int n = int.Parse(Console.ReadLine());
        //int n = 4;

        int height = 2 * n;
        int width = 3 * n + 1;
        int drawinArea = 3 * n - 1;
        int topAndBottom = n - 1;
        int topAndBottomDots = n + 1;

        //1.         
        //.......*****.......
        Console.Write(new string('.', topAndBottomDots));
        Console.Write(new string('*', topAndBottom));
        Console.WriteLine(new string('.', topAndBottomDots));
        //2.  
        //.....*.......*.....
        //...*...........*...
        //.*..2..4..6..8..10..12..14.15*.

        int middleRows = n / 2;
        for (int i = 0; i < middleRows; i++)
        {

            Console.Write(new string('.', n - 1 - 2 * i));
            Console.Write('*');
            Console.Write(new string('.', n + 1 + 4 * i));
            Console.Write('*');
            Console.WriteLine(new string('.', n - 1 - 2 * i));
        }
        //3.
        //.*...............*.
        int aboveDrawingArea = n - (2 + middleRows);  //2 is the first and first part drawing area

        if (aboveDrawingArea > 0)
        {
            for (int i = 0; i < aboveDrawingArea; i++)
            {
                Console.Write(new string('.', 1));
                Console.Write('*');
                Console.Write(new string('.', width - 4));  //minus 4 == 2 * '.' + 2 * '*'
                Console.Write('*');
                Console.WriteLine(new string('.', 1));
            }
        }
        //  .*.@.@.@.@.@.@.@.*.
        //  .*@.@.@.@.@.@.@.@*.
        for (int row = 1; row <= 2; row++)
        {

            string egg = ".@";
            string eggTwo = "@.";
            int repeat = (width - 4) / 2;

            if (row % 2 != 0)
            {
                Console.Write(new string('.', 1));
                Console.Write('*');
                Console.Write(string.Concat(Enumerable.Repeat(eggTwo, repeat)));
                Console.Write(new string('@', 1));
                Console.Write('*');
                Console.WriteLine(new string('.', 1));
            }
            else
            {
                Console.Write(new string('.', 1));
                Console.Write('*');
                Console.Write(string.Concat(Enumerable.Repeat(egg, repeat)));
                Console.Write(new string('.', 1));
                Console.Write('*');
                Console.WriteLine(new string('.', 1));
            }
        }
        //   5  .*...............*.
        if (aboveDrawingArea > 0)
        {
            for (int i = 0; i < aboveDrawingArea; i++)
            {
                Console.Write(new string('.', 1));
                Console.Write('*');
                Console.Write(new string('.', width - 4));  //minus 4 == 2 * '.' + 2 * '*'
                Console.Write('*');
                Console.WriteLine(new string('.', 1));
            }
        }
        //    6 .*...............*.
        //      ...*...........*...
        //      .....*.......*.....
        for (int i = middleRows - 1; i >= 0; i--)
        {
            Console.Write(new string('.', n - 1 - 2 * i));
            Console.Write('*');
            Console.Write(new string('.', n + 1 + 4 * i));
            Console.Write('*');
            Console.WriteLine(new string('.', n - 1 - 2 * i));
        }
        //    7 .......*****.......

        Console.Write(new string('.', topAndBottomDots));
        Console.Write(new string('*', topAndBottom));
        Console.WriteLine(new string('.', topAndBottomDots));
    }
}
