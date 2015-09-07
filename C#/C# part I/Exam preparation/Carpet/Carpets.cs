using System;

class Carpets
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int halfN = N / 2;


        for (int i = 1; i <= halfN; i++)
        {
            Console.Write(new string('.', halfN - i));
            Console.Write(new string('/', i));
            Console.Write(new string('\\', i));
            Console.WriteLine(new string('.', halfN - i));
        }
        for (int i = 0; i < halfN; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('\\', halfN - i));
            Console.Write(new string('/', halfN - i));
            Console.WriteLine(new string('.', i));
        }
    }
}
