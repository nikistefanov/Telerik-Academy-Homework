namespace PetStore.Importer.Importers
{
    using System;
    using System.IO;
    using System.Linq;

    using PetStore.Data;
    using PetStore.Importer.Content;

    public class ProductsImporter : IImporter
    {
        private const int NumberOfProducts = 20000;

        public string Message
        {
            get { return "Importing Products"; }
        }

        public int Order
        {
            get { return 5; }
        }

        public Action<PetStoreEntities, TextWriter> Get
        {
            get
            {
                return (db, tr) =>
                    {
                        var categoriesId = db.Categories
                            .Select(c => c.CategoryId)
                            .ToList();

                        var speciesIds = db.Species
                            .Select(s => s.SpeciesId)
                            .ToList();

                        for (int i = 0; i < NumberOfProducts; i++)
                        {
                            var randomCategoryIndex = RandomGenerator.GetRandomNumber(0, categoriesId.Count - 1);
                            var randomCategoryId = categoriesId[randomCategoryIndex];

                            var randomSpeciesIndex = RandomGenerator.GetRandomNumber(0, speciesIds.Count - 1);
                            var randomSpeciesId = speciesIds[randomSpeciesIndex];

                            db.Products.Add(new Product
                                {
                                    Name = RandomGenerator.GetRandomString(5, 25),
                                    Price = RandomGenerator.GetRandomNumber(10, 1000),
                                    CategoryId = randomCategoryId,
                                    SpeciesId = randomSpeciesId
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
