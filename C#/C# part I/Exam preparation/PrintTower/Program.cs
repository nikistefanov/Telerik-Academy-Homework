using System;

class Program
{
    static void Main(string[] args)
    {

        int H = int.Parse(Console.ReadLine());

        //          1........../\.......... 
        //          2........./--\.........      -1 (row2)
        //          3......../....\........         (+2)     == update
        //          4......./------\.......      -3 (row4)   == update++
        //          5....../........\......         (+3)     == update
        //          6...../..........\.....
        //          7..../------------\....      -6 (row7)
        //          8.../..............\...         (+4)
        //          9../................\..
        //         10./..................\.
        //         11/--------------------\     -10 (row11)
        //                                           (+5)

        int update = 2; //for the example first gap is 2 times + (row 2 then row 4) 
        int rowToHaveDash = 2;  //cuz we start the rows from 1 and from the condition the first '-' is on row 2;

        for (int i = 1; i <= H; i++)
        {
            char middleChar = '.';
            if (i == rowToHaveDash) //in the condition is said firs '-' is on row 2
            {
                middleChar = '-';
                rowToHaveDash += update;   //add new 
                update++; //(row 2 (+2) row 4 => now ++ => row 4 (+3) row 7
            }
            Console.Write(new string('.', H - i));
            Console.Write("/");
            //print middleChar --> 2 * i - 2 
            //example with row 1 ==> 2 * 1 - 2 = 2 - 1 = 0 (dash/dot to print)
            //example with row 2 ==> 2 * 2 - 2 = 4 - 2 = 2 (dashes/dots to print)
            //example with row 3 ==> 2 * 3 - 2 = 6 - 2 = 4 (dashes/dots to print)
            Console.Write(new string(middleChar, 2 * i - 2));
            Console.Write("\\");
            Console.Write(new string('.', H - i));
            Console.WriteLine();
        }

    }
}
