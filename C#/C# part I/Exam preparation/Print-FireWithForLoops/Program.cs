using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());


        //fire = top part 1              n / 2 - going up (rows)
        //   ...##...       -> dots = n/2 - row - 1      example: 4 - 0 - 1 = 3 ==> 3 dots
        //   ..#..#..       -> inDots = row * 2          example: 1 * 2 = 2 ==> 2 inDots
        //   .#....#.
        //   #......#
        for (int row = 0; row < n / 2; row++)
        {
            for (int i = 0; i < n / 2 - row - 1; i++)
            {
                Console.Write('.');
            }
            Console.Write('#');
            for (int i = 0; i < row * 2; i++)
            {
                Console.Write('.');
            }
            Console.Write('#');
            for (int i = 0; i < n / 2 - row - 1; i++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
        //fire = top part 2            n / 4 - going down (rows0
        //   #......#
        //   .#....#.
        for (int row = 0; row < n / 4; row++)
        {
            for (int i = 0; i < row; i++)   //first time row = 0 so no dots will be printed
            {
                Console.Write('.');
            }
            Console.Write('#');
            //example: n = 8...
            // (row1)-> 8 - 0(which is the first dot) - 0 (which is the last dot) - 2 (which are the two '#' symbols) = 6 inDots
            // (row2)-> 8 - 1(row) - 1(row) - 2('#' symbols) = 4 inDots
            for (int i = 0; i < n - row - row - 2; i++)
            {
                Console.Write('.');
            }
            Console.Write('#');
            for (int i = 0; i < row; i++) //first time row = 0 so no dots will be printed
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
        //dash
        // --------     = n;
        for (int i = 0; i < n; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine();

        //holder
        //row 0 - \\\\////    -> . = 0  (dot < row)         n/2-0  \      n/2-0    /           (where 0 is the row)  n / 2 - row
        //row 1 - .\\\///.    -> . = 1  (dot < row)         n/2-1  \      n/2-1    /           (where 1 is the row)  n / 2 - row
        //row 2 - ..\\//..    -> . = 2  (dot < row)         n/2-2  \      n/2-2    /           (where 2 is the row)  n / 2 - row
        //row 3 - ...\/...    -> . = 3  (dot < row)         n/2-3  \      n/2-3    /           (where 3 is the row)  n / 2 - row
        for (int row = 0; row < n / 2; row++)
        {
            for (int dot = 0; dot < row; dot++)
            {
                Console.Write('.');
            }
            for (int i = 0; i < n / 2 - row; i++)
            {
                Console.Write('\\');
            }
            for (int i = 0; i < n / 2 - row; i++)
            {
                Console.Write('/');
            }
            for (int dot = 0; dot < row; dot++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}