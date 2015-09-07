//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:

//URL	Information
//http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
//[server] = telerikacademy.com 
//[resource] = /Courses/Courses/Details/212

using System;
using System.Linq;
using System.Collections.Generic;

class ParsingURLs
{
    static void InformationAboutURL(string url)
    {
        string newLink = url;

        int endIndex = newLink.IndexOf("://");
        string protocol = url.Substring(0, endIndex);
        newLink = newLink.Remove(0, protocol.Length + 3);

        endIndex = newLink.IndexOf("/");
        string server = newLink.Substring(0, endIndex);
        newLink = newLink.Remove(0, server.Length + 1);

        endIndex = newLink.Length;
        string resource = newLink.Substring(0, endIndex);
        newLink = newLink = string.Empty;

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }

    static void Main(string[] args)
    {
        string link = @"http://telerikacademy.com/Courses/Courses/Details/212";

        InformationAboutURL(link);

    }
}
