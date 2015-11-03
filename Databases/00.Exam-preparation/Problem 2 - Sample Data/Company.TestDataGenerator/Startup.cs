namespace Company.TestDataGenerator
{
    using System;

    class Startup
    {
        static void Main()
        {
            SampleDataImporter.Create(Console.Out).Import(); 
        }
    }
}
