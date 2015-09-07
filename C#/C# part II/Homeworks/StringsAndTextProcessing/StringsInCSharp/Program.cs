//Problem 1. Strings in C#.

//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader(@"..\..\Files\info.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
                Console.WriteLine("Bye now.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found....");
        }
    }
}