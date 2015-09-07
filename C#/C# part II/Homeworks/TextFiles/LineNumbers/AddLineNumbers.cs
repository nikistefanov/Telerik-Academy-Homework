//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

class AddLineNumbers
{
    static void Main()
    {
        try
        {
            StreamReader sReader = new StreamReader(@"..\..\input.txt");
            StreamWriter sWriter = new StreamWriter(@"..\..\output.txt", true);

            using (sWriter)
            {
                using (sReader)
                {
                    string line = sReader.ReadLine();
                    int counter = 1;
                    while (line != null)
                    {
                        string lineNumber = counter.ToString() + " : ";
                        sWriter.WriteLine(lineNumber + line);
                        line = sReader.ReadLine();
                        counter++;
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
