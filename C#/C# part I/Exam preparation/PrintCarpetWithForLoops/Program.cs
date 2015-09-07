using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        //row 0 - .../\...   -> 3 dots (dot < n/2 - row - 1)[3 = 4 - 0 - 1]    /\    1 slash (slash < row+1)[1 = 0 + 1]
        //row 1 - ..//\\..   -> 2 dots (dot < n/2 - row - 1)[2 = 4 - 1 - 1]   //\\   2 slash (slash < row+1)[2 = 1 + 1]
        //row 2 - .///\\\.   -> 1 dots (dot < n/2 - row - 1)[1 = 4 - 2 - 1]  ///\\\  3 slash (slash < row+1)[3 = 2 + 1]
        //row 3 - ////\\\\   -> 0 dots (dot < n/2 - row - 1)[0 = 4 - 3 - 1] ////\\\\ 4 slash (slash < row+1)[4 = 3 + 1]   
        for (int row = 0; row < n / 2; row++)
        {
            for (int dot = 0; dot < n / 2 - row - 1; dot++)
            {
                Console.Write('.');
            }
            for (int slash = 0; slash < row + 1; slash++)
            {
                Console.Write('/');
            }
            for (int slash = 0; slash < row + 1; slash++)
            {
                Console.Write('\\');
            }
            for (int dot = 0; dot < n / 2 - row - 1; dot++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
        //
        //using reverse method of the bottom of the carpet!!!
        //
        //for (int row = n / 2 - 1; row >= 0; row--)
        //{
        //    for (int dot = 0; dot < row; dot++)
        //    {
        //        Console.Write('.');
        //    }
        //    for (int i = 0; i < n / 2 - row; i++)
        //    {
        //        Console.Write('/');
        //    }
        //    for (int i = 0; i < n / 2 - row; i++)
        //    {
        //        Console.Write('\\');
        //    }
        //    for (int dot = 0; dot < row; dot++)
        //    {
        //        Console.Write('.');
        //    }
        //    Console.WriteLine();
        //}

        //row 0 - \\\\////    -> 0 dots (dot < row)[0 = 0]   \\\\////     4 slash (slash < n/2 - row)[4 = 4 - 0]
        //row 1 - .\\\///.    -> 1 dots (dot < row)[1 = 1]    \\\///      3 slash (slash < n/2 - row)[3 = 4 - 1]
        //row 2 - ..\\//..    -> 2 dots (dot < row)[2 = 2]     \\//       2 slash (slash < n/2 - row)[2 = 4 - 2]
        //row 3 - ...\/...    -> 3 dots (dot < row)[3 = 3]      \/        1 slash (slash < n/2 - row)[1 = 4 - 3]

        for (int row = 0; row < n / 2; row++)
        {
            for (int dot = 0; dot < row; dot++)
            {
                Console.Write('.');
            }
            for (int slash = 0; slash < n / 2 - row; slash++)
            {
                Console.Write('\\');
            }
            for (int slash = 0; slash < n / 2 - row; slash++)
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
