/*Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
Use tags <file> and <dir> with appropriate attributes.
For the generation of the XML document use the class XmlWriter.*/

namespace TraverseDirectory
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    class StartProgram
    {
        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../directory.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 2;

                string pathToDirectoryXml = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);

                writer.WriteStartDocument();
                writer.WriteStartElement("directories");
                TraverseDirectory(pathToDirectoryXml, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("XML document was saved.");
        }

        static void TraverseDirectory(string dir, XmlTextWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                TraverseDirectory(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                writer.WriteAttributeString("ext", Path.GetExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}
