﻿using System;
using System.Numerics;  //*2* i need this for the 2 example
using System.Text;      //*3* for 3 example

class Test
{
    static void Main()
    {
        //*1*first example - current date
        //DateTime current = DateTime.Now;
        //Console.WriteLine(current);
        //*1*end

        //*2*{BigInteger} is special type that can hold bigger number than the one in the {ulong} type
        //*2*using System.Numerics;
        //BigInteger bigNum = 10000000000000000000;
        //BigInteger veryBigNum = bigNum * bigNum * bigNum * bigNum * bigNum;
        //Console.WriteLine(veryBigNum);
        //*2*end

        //*3*
        //Console.OutputEncoding = Encoding.Unicode; //smenq koda koito polzva na Unicode (za text), moje /  i drug kod: UTF8, i t.n.                                                   
        //Console.WriteLine("Ники");
        //*3*end

        //*4* print of char and convert to int
        //char symbol = 'a';
        //Console.WriteLine("code of 'a' is: {0}", (int)symbol);
        //*4* end

        char symbol = '\u002A';
        Console.WriteLine(symbol);
        int dec = 0xFE;
        Console.WriteLine(dec);
    }
}