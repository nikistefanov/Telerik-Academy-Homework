//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class ExtractTextXML
{
    static void Main()
    {
        char[] separators = { ',', '.', ' ', '\t', '\n' };
        using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
        {
            string XMLtoString = reader.ReadToEnd();
            string changed = RemoveTags(XMLtoString).Replace("</a>", " ");

        }
    }

    static List<string> RemoveTags(string someText)
    {
        List<string> sb = new List<string>();
        sb.Append(someText);
        while (sb.ToString().Contains("<") || sb.ToString().Contains(">"))
        {
            int start = sb.ToString().IndexOf("<");
            int end = sb.ToString().IndexOf(">");
            sb.Remove(start, end - start + 1);
        }
        return sb;
    }
}
