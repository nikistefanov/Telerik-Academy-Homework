using System;
using System.Text;

class FireFast
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int halfN = N / 2;
        StringBuilder final = new StringBuilder();
        string dash = new string('-', N);

        //Fire Top
        for (int i = 0; i < halfN; i++)
        {
            final.Append(new string('.', halfN - (i + 1)));
            final.Append('#');
            final.Append(new string('.', i * 2));
            final.Append('#');
            final.AppendLine(new string('.', halfN - (i + 1)));
        }
        //Fire Bottom
        for (int i = 0; i < N / 4; i++)
        {
            final.Append(new string('.', i));
            final.Append('#');
            final.Append(new string('.', N - ((i * 2) + 2)));
            final.Append('#');
            final.AppendLine(new string('.', i));
        }
        //Dash
        final.AppendLine(dash);

        //Torch
        for (int i = 0; i < halfN; i++)
        {
            final.Append(new string('.', i));
            final.Append(new string('\\', halfN - i));
            final.Append(new string('/', halfN - i));
            final.AppendLine(new string('.', i));
        }
        Console.WriteLine(final);
    }
}