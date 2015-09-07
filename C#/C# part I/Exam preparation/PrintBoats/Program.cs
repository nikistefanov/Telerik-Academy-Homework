using System;

class Program
{
    static void Main(string[] args)
    {
        //        first part
        //        .....*.....
        //        second part
        //        ....***....
        //        ...*.*.*...
        //        ..*..*..*..
        //        .*...*...*.
        //        third part
        //        ***********
        //        fourth part
        //        .*...*...*.
        //        ..*..*..*..
        //        fifth part
        //        ...*****...

        int N = int.Parse(Console.ReadLine());
        //int N = 5;

        int widt = N * 2 + 1;
        int height = 6 + ((N - 3) / 2) * 3;

        //int topDots = (widt - N) / 2;
        //int nextDots = topDots - 1;

        int bottomRow = ((widt - N) / 2);
        var bottomDots = bottomRow;

        //first part
        //.....*.....
        Console.Write(new string('.', N));
        Console.Write('*');
        Console.WriteLine(new string('.', N));


        //second part
        //....***....
        //...*.*.*...
        //..*..*..*..
        //.*...*...*.
        for (int i = 0; i < N - 1; i++)
        {
            Console.Write(new string('.', N - 1 - i));
            Console.Write('*');
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.WriteLine(new string('.', N - 1 - i));
        }
        //third part
        //***********
        Console.WriteLine(new string('*', widt));
        //fourth part
        //.*...*...*.
        //..*..*..*..

        int firstDots = 1;
        for (int i = 0; i < bottomRow - 1; i++)
        {
            //middleDots--;
            Console.Write(new string('.', firstDots));
            Console.Write('*');
            Console.Write(new string('.', N - 2 - i));
            Console.Write('*');
            Console.Write(new string('.', N - 2 - i));
            Console.Write('*');
            Console.WriteLine(new string('.', firstDots));
            firstDots++;
        }
        //  fifth part
        //  ...*****...
        Console.Write(new string('.', bottomDots));
        Console.Write(new string('*', N));
        Console.WriteLine(new string('.', bottomDots));
    }
}
