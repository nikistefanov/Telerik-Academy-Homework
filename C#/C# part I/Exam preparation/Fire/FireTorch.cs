using System;

class FireTorch
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int halfN = N / 2;
        string dash = new string('-', N);

        //Fire Top
        //...##...
        //..#..#..
        //.#....#.
        //#......#
        for (int i = 0; i < halfN; i++)
        {
            Console.Write(new string('.', halfN - (i + 1)));
            Console.Write('#');
            Console.Write(new string('.', i * 2));
            Console.Write('#');
            Console.WriteLine(new string('.', halfN - (i + 1)));
        }
        //Fire Bottom
        //#......#
        //.#....#.
        for (int i = 0; i < N / 4; i++)
        {
            Console.Write(new string('.', i));
            Console.Write('#');
            Console.Write(new string('.', N - ((i * 2) + 2)));
            Console.Write('#');
            Console.WriteLine(new string('.', i));
        }
        //Dash
        //--------
        Console.WriteLine(dash);

        //Torch
        //\\\\////
        //.\\\///.
        //..\\//..
        //...\/...
        for (int i = 0; i < halfN; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('\\', halfN - i));
            Console.Write(new string('/', halfN - i));
            Console.WriteLine(new string('.', i));
        }
    }
}