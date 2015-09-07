//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class MergeText
{
    static StreamWriter ConcatenateText(StreamReader reader)
    {
        StreamWriter writer = new StreamWriter(@"..\..\output.txt", true);
        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
        return writer;
    }
    
    static void Main()
    {
        try
        {
            StreamReader firstText = new StreamReader(@"..\..\firstText.txt");
            StreamReader secondText = new StreamReader(@"..\..\secondText.txt");
            ConcatenateText(firstText);
            ConcatenateText(secondText);
           
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
