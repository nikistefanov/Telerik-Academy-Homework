namespace CreateXmlStylesheetAndTransformToHtml
{
    using System.Xml.Xsl;

    class Transformers
    {
        static void Main()
        {
            string pathToCatalogXml = "../../../Content/catalog.xml";
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../catalogue.xslt");
            xslt.Transform(pathToCatalogXml, "../../catalogue.html");

            System.Console.WriteLine("An HTML file waws created.");
        }
    }
}
