//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class FileRead
{
    static void Main()
    {
        Console.WriteLine("Please, enter the path of the file you want to be read.");
        string filePath = Console.ReadLine();
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        catch (ArgumentNullException anx)
        {
            Console.WriteLine(anx.Message);
        }
        catch (ArgumentException ax)
        {
            Console.WriteLine(ax.Message);
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