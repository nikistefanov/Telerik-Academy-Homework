namespace ExtractAllSongsUsingXDocument
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class SongsExtractor
    {
        static void Main()
        {
            var document = XDocument.Load("../../../Content/catalog.xml");
            var albums = document.Element("catalogue").Elements("album");

            var titles = from title in albums.Descendants("title") select title.Value;

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
