namespace ExtractPricesUsingLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class PriceExtractor
    {
        static void Main()
        {
            var document = XDocument.Load("../../../Content/catalog.xml");

            var albums = from album in document.Descendants("album")
                         where int.Parse(album.Element("year").Value) <= (DateTime.Now.Year - 5)
                         //select album.Element("name").Value;
                         select new
                         {
                             Name = album.Element("name").Value.Trim(),
                             Year = album.Element("year").Value.Trim()
                         };

            foreach (var album in albums)
            {
                Console.WriteLine("Album: {0}; Year: {1}", album.Name, album.Year);
            }
        }
    }
}
