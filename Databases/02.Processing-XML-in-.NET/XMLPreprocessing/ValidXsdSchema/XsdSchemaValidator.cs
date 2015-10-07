namespace ValidXsdSchema
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    class XsdSchemaValidator
    {
        static void Main()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", "../../../Content/catalog.xsd");

            var document = XDocument.Load("../../catalog.xml");

            Console.WriteLine("Validating XML file...");
            bool errors = false;
            document.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });
            Console.WriteLine("XML file {0}", errors ? "did not validate" : "validated");

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Add something incorrect in \"catalog.xml\" like deleting the <year> tag");
            document.Root.Elements("album").Elements("year").Remove();
            //Console.WriteLine(document);
            
            Console.WriteLine("Validating XML file...");
            errors = false;
            document.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });
        }
    }
}
