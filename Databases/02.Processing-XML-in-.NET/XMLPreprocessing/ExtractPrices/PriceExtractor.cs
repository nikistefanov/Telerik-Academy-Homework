/*Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
Use XPath query.*/

namespace ExtractPrices
{
    using System;
    using System.Xml;

    class PriceExtractor
    {
        static void Main()
        {
            XmlDocument document = new XmlDocument();
            document.Load("../../../Content/catalog.xml");

            var query = String.Format("/catalogue/album[year<={0}]", DateTime.Now.Year - 5);

            var albums = document.SelectNodes(query);

            foreach (XmlNode node in albums)
            {
                Console.WriteLine("Album: {0}; Year: {1}", node["name"].InnerText, node["year"].InnerText);
            }
        }
    }
}
