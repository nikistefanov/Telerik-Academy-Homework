/*Rewrite the last exercises using XDocument, XElement and XAttribute.*/

namespace TraversDirectoryUsingXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class StartProgram
    {
        static void Main()
        {
            var pathToDirectoryXml = TraverseDirectory(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu));
            pathToDirectoryXml.Save("../../directory.xml");

            Console.WriteLine("XML documents saved!");
        }

        static XElement TraverseDirectory(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(TraverseDirectory(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }
    }
}
