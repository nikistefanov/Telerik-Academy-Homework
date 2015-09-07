//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class FileDownloading
{
    static void Main()
    {
        Console.WriteLine("Please, enter the URL of the file you want to be downloaded.");
        string linkForDownload = Console.ReadLine();
        Console.WriteLine("Plese, enter the name of the file.");
        string fileForDownload = Console.ReadLine();
        try
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile(linkForDownload, fileForDownload);
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Please enter a valid link!");
        }
        catch (WebException)
        {
            Console.WriteLine("Link not found!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Not supported");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }

    }
}
