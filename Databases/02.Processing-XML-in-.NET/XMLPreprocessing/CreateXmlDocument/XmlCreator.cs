/*In a text file we are given the name, address and phone number of given person(each at a single line).
Write a program, which creates new XML document, which contains these data in structured XML format.*/

namespace CreateXmlDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class XmlCreator
    {
        static void Main()
        {
            using (StreamReader streamReader = new StreamReader("../../personInfo.txt"))
            {
                string name = streamReader.ReadLine();
                string address = streamReader.ReadLine();
                string phone = streamReader.ReadLine();

                XElement personXml = new XElement("person",
                    new XElement("name", name),
                    new XElement("adress", address),
                    new XElement("phone", phone));

                Console.WriteLine(personXml);
                string pathForPersonXml = "../../person.xml";
                personXml.Save(pathForPersonXml);
                Console.WriteLine("File was saved at: {0}", pathForPersonXml);
            }
        }
    }
}
