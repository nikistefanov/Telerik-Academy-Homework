namespace Company.TestDataGenerator.Importers
{
    using System;
    using System.IO;

    using Company.Data;

    public interface IImporter
    {
        string Message { get; }

        int Order { get;}

        Action<CompanyEntities, TextWriter> Get { get; }
    }
}
