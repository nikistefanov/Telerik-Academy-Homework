namespace PetStore.Importer.Importers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using PetStore.Data;
    using PetStore.Importer.Content;

    public class SpeciesImporter : IImporter
    {
        private const int NumberOfSpecies = 100;

        public string Message
        {
            get { return "Importing Species"; }
        }

        public int Order
        {
            get { return 2; }
        }

        public Action<PetStoreEntities, TextWriter> Get
        {
            get
            {
                return (db, tr) =>
                    {
                        var countriesIds = db.Countries
                            .Select(c => c.CountryId)
                            .ToList();

                        var uniqueSpecies = new HashSet<string>();

                        while (uniqueSpecies.Count < NumberOfSpecies)
                        {
                            uniqueSpecies.Add(RandomGenerator.GetRandomString(3, 20));
                        }

                        for (int i = 0; i < countriesIds.Count; i++)
                        {
                            var numberOfCountriesPerSpecies = RandomGenerator.GetRandomNumber(3, 7);

                            for (int j = 0; j < numberOfCountriesPerSpecies; j++)
                            {
                                db.Species.Add(new Species
                                {
                                    Name = RandomGenerator.GetRandomString(3, 30),
                                    CountryId = countriesIds[i]
                                });
                            }

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
