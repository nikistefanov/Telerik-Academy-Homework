using System;

class PrintASCII
{
    static void Main()
    {
        Console.Title = "ASCII Table";

        Console.OutputEncoding = System.Text.Encoding.Unicode;

        for (int symbol = 0; symbol <= 255; symbol++)
			{
			    Console.Write("{0} = {1}", symbol, (char)symbol + "\t");
                if (symbol % 7 == 0)
                {
                    Console.WriteLine();
                }               
			}
       Console.WriteLine();
    }
}
