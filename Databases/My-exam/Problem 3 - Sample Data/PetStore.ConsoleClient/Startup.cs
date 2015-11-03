namespace PetStore.ConsoleClient
{
    using System;
    using System.Linq;

    using PetStore.Importer;

    public class Startup
    {
        public static void Main()
        {
            SampleDataImporter.Create(Console.Out).Import(); 
        }
    }
}
