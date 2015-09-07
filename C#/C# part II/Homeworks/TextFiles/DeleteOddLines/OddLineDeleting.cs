//Problem 9. Delete odd lines

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class OddLineDeleting
{
    static void Main()
    {
        try
        {
            List<string> changedText = new List<string>();

            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                

                string line = reader.ReadLine();
                int countLine = 1;
                while (line != null)
                {
                    if (countLine % 2 == 0)
                    {
                        changedText.Add(line);
                    }
                    line = reader.ReadLine();
                    countLine++;
                }

            }
            using (StreamWriter writer = new StreamWriter(@"..\..\text.txt", false))
            {
                foreach (var line in changedText)
                {
                    writer.WriteLine(line);
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
        finally
        {
            Console.WriteLine("Job done!");
        }
    }
}
