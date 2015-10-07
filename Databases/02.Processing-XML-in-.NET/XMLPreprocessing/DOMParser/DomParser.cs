/*
Write program that extracts all different artists which are found in the catalog.xml.
For each author you should print the number of albums in the catalogue.
Use the DOM parser and a hash-table.
*/

namespace XMLProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class DomParser
    {
        static void Main()
        {
            XmlDocument document = new XmlDocument();
            document.Load("../../../Content/catalog.xml");
            
            XmlNode root = document.DocumentElement;

            var artists = new Dictionary<string, int>();

            foreach (XmlNode node in root.ChildNodes)
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name == "artist")
                    {
                        if (artists.ContainsKey(child.InnerText))
                        {
                            artists[child.InnerText]++;
                        }
                        else
                        {
                            artists.Add(child.InnerText, 1);
                        }
                    }
                }
            }

            foreach (var artist in artists)
            {
                Console.Write("{0} has {1} ", artist.Key, artist.Value);
                var albumOrAlbums = artist.Value > 1 ? "albums" : "album";
                Console.WriteLine(albumOrAlbums);
            }



        }
    }
}
