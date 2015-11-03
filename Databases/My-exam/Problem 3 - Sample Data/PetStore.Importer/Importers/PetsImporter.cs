namespace PetStore.Importer.Importers
{
    using System;
    using System.IO;
    using System.Linq;

    using PetStore.Data;
    using PetStore.Importer.Content;

    public class PetsImporter : IImporter
    {
        private const int NumberOfPets = 5000;
        private const int NumberOfDaysBefore = 60;
        private readonly DateTime noOlderThanYear = new DateTime(2010, 1, 1, 0, 0, 0);

        public string Message
        {
            get { return "Importing Pets (Puppieeeees!)"; }
        }

        public int Order
        {
            get { return 3; }
        }

        public Action<PetStoreEntities, TextWriter> Get
        {
            get
            {
                return (db, tr) =>
                    {
                        var colorsIds = db.Colors
                            .Select(c => c.ColorId)
                            .ToList();

                        var speciesIds = db.Species
                            .Select(s => s.SpeciesId)
                            .ToList();

                        for (int i = 0; i < NumberOfPets; i++)
                        {
                            var randomColorIndex = RandomGenerator.GetRandomNumber(0, colorsIds.Count - 1);
                            var randomColorId = colorsIds[randomColorIndex];

                            var randomSpeciesIndex = RandomGenerator.GetRandomNumber(0, speciesIds.Count - 1);
                            var randomSpeciesId = speciesIds[randomSpeciesIndex];

                            var randomDateAndTime = RandomGenerator.GetRandomDate(after: noOlderThanYear, before: DateTime.Now.AddDays(-NumberOfDaysBefore));

                            var isTimeToBreed = i % 2 == 0;

                            db.Pets.Add(new Pet
                            {
                                SpeciesId = randomSpeciesId,
                                DateAndTimeOfBirth = randomDateAndTime,
                                Price = RandomGenerator.GetRandomNumber(5, 2500),
                                ColorId = randomColorId,
                                Breed = isTimeToBreed ? null : RandomGenerator.GetRandomString(5, 30)
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
