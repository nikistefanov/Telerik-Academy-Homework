namespace PetStore.Importer.Importers
{
    using System;
    using System.IO;
    using System.Linq;

    using PetStore.Data;
    using PetStore.Importer.Content;

    public class CategoriesImporter : IImporter
    {
        private const int NumberOfCategories = 50;

        public string Message
        {
            get { return "Importing Categories"; }
        }

        public int Order
        {
            get { return 4; }
        }

        public Action<PetStoreEntities, TextWriter> Get
        {
            get
            {
                return (db, tr) =>
                    {
                        for (int i = 0; i < NumberOfCategories; i++)
                        {
                            db.Categories.Add(new Category
                                {
                                    Name = RandomGenerator.GetRandomString(5, 20)
                                });

                            if (i % 10 == 0)
                            {
                                tr.Write(".");
                            }

                            if (i % 100 == 0)
                            {
                                db.SaveChanges();
                                db.Dispose();
                                db = new PetStoreEntities();
                            }
                        }

                        db.SaveChanges();
                    };
            }
        }
    }
}
