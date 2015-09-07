//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.


using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class SortNames
{
    static void Main()
    {
        char[] separators = { ',', '.', ' ', '\t', '\n' };
        try
        {
            StreamReader sReader = new StreamReader(@"..\..\input.txt");
            StreamWriter sWriter = new StreamWriter(@"..\..\output.txt");

            using (sReader)
            {

                string[] changedText = sReader.ReadToEnd().Split(separators)
                                              .OrderBy(x => x)
                                              .ToArray();
                using (sWriter)
                {
                    foreach (var line in changedText)
                    {
                        sWriter.WriteLine(line);
                    }
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
