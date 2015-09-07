//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class ReadOddLines
{
    static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader(@"..\..\text.txt"))
            {
                string line = sr.ReadLine();
                int countLine = 1;
                while (line != null)
                {
                    if (countLine % 2 != 0)
                    {
                        Console.WriteLine("Line {0} - {1}", countLine, line);
                    }
                    line = sr.ReadLine();
                    countLine++;
                }
            }
        }
        catch (DirectoryNotFoundException dx)
        {
            Console.WriteLine(dx.Message);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You dont have permission to open this file/directory!");
        }
        catch (IOException iox)
        {
            Console.WriteLine(iox.Message);
        }
    }
}
