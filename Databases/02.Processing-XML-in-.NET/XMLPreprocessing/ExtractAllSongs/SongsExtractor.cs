/*Write a program, which using XmlReader extracts all song titles from catalog.xml*/

namespace ExtractAllSongs
{
    using System;
    using System.Xml;

    class SongsExtractor
    {
        static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../../Content/catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element))
                    {
                        if (reader.Name == "title")
                        {
                            Console.WriteLine(reader.ReadElementString());
                        }
                    }
                }
            }
        }
    }
}
