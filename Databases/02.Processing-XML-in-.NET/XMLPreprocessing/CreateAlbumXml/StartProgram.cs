/*Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml, 
in which stores in appropriate way the names of all albums and their authors.*/

namespace CreateAlbumXml
{
    using System;
    using System.Text;
    using System.Xml;

    class StartProgram
    {
        static void Main()
        {
            string pathToAlbumXml = "../../album.xml";
            Encoding encoding = Encoding.GetEncoding("UTF-8");

            using (XmlTextWriter writer = new XmlTextWriter(pathToAlbumXml, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                using (XmlReader reader = XmlReader.Create("../../../Content/catalog.xml"))
                {
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element))
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album");
                                writer.WriteElementString("name", reader.ReadElementString());
                            }
                            else if (reader.Name == "artist")
                            {
                                writer.WriteElementString("artist", reader.ReadElementString());
                                writer.WriteEndElement();
                            }
                        }
                    }
                }

                writer.WriteEndDocument();
            }

            Console.WriteLine("Album was saved at: {0}", pathToAlbumXml);
        }
    }
}
