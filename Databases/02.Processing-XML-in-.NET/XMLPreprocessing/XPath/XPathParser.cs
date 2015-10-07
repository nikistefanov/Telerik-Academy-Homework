namespace XPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    class XPathParser
    {
        static void Main()
        {
            XmlDocument document = new XmlDocument();
            document.Load("../../../Content/catalog.xml");

            //Console.WriteLine(document.OuterXml);
            XmlNode root = document.DocumentElement;

            string xPathQuery = "/catalogue/album";

            XmlNodeList artistsNodes = document.SelectNodes(xPathQuery);

            var artists = new Dictionary<string, int>();

            foreach (XmlNode node in artistsNodes)
            {
                string currentArtistName = node.SelectSingleNode("artist").InnerText;
                if (artists.ContainsKey(currentArtistName))
                {
                    artists[currentArtistName]++;
                }
                else
                {
                    artists.Add(currentArtistName, 1);
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
