namespace PetStore.Importer
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using PetStore.Data;

    public class SampleDataImporter
    {
        private TextWriter textWriter;

        private SampleDataImporter(TextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public static SampleDataImporter Create(TextWriter textWriter)
        {
            return new SampleDataImporter(textWriter);
        }

        public void Import()
        {
            Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IImporter).IsAssignableFrom(t)
                && !t.IsInterface
                && !t.IsAbstract)
                .Select(t => Activator.CreateInstance(t))
                .OfType<IImporter>()
                .OrderBy(i => i.Order)
                .ToList()
                .ForEach(i =>
                {
                    textWriter.Write(i.Message);

                    var db = new PetStoreEntities();
                    i.Get(db, this.textWriter);

                    textWriter.WriteLine();
                });
        }
    }
}
