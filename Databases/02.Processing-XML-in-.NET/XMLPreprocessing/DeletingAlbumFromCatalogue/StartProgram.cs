namespace DeletingAlbumFromCatalogue
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Xml;

    class StartProgram
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            XmlDocument document = new XmlDocument();
            document.Load("../../../Content/catalog.xml");

            XmlNode root = document.DocumentElement;

            var priceLimit = 20;


            foreach (XmlNode album in root.ChildNodes)
            {
                var priceNode = album["price"];
                var price = Double.Parse(priceNode.InnerText);

                if (price > priceLimit)
                {
                    root.RemoveChild(album);
                }
            }
            string pathForCalatalogue = "../../CatalogWithCheapAlbums.xml";
            document.Save(pathForCalatalogue);
            Console.WriteLine("Album was saved at: {0}", pathForCalatalogue);
        }
    }
}
