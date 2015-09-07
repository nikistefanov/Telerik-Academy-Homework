using System;

class Program
{
    static void Main()
    {
//      1.
//      ...*...
//      ..***..
//      .*****.
//      *******
//      2.
//      ...*...

        int n = int.Parse(Console.ReadLine());
        int height = n;
        int width = (2 * n) - 3;
        int star = 1;
        int dots = n - 2;

        //1.
        for (int row = 0; row < height - 1; row++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('*', star));
            Console.WriteLine(new string('.', dots));
            dots--;
            star += 2;
        }
        //1.
        star = 1;
        dots = n - 2;
        Console.Write(new string('.', dots));
        Console.Write(new string('*', star));
        Console.WriteLine(new string('.', dots));
    }
}
