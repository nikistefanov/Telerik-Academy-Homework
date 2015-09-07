//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;

class ComparingTextFiles
{
    static void Main()
    {
        try
        {
            StreamReader firstText = new StreamReader(@"..\..\firstText.txt");
            StreamReader secondText = new StreamReader(@"..\..\secondText.txt");
            using (firstText)
            {
                using (secondText)
                {
                    string lineTextOne = firstText.ReadLine();
                    string lineTextTwo = secondText.ReadLine();
                    int equal = 0;
                    int different = 0;
                    while (lineTextOne != null && lineTextTwo != null)
                    {
                        if (lineTextOne.CompareTo(lineTextTwo) == 0)
                        {
                            equal++;
                        }
                        else
                        {
                            different++;
                        }
                        lineTextOne = firstText.ReadLine();
                        lineTextTwo = secondText.ReadLine();
                    }
                    Console.WriteLine("Equals lines = {0}\nDifferent lines = {1}", equal, different);
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
