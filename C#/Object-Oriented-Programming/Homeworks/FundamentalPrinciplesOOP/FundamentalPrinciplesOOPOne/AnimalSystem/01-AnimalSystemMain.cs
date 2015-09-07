//Problem 3. Animal hierarchy

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).


namespace AnimalSystem
{
    using System;
    using System.Linq;

    class AnimalSystemMain
    {
        static void Main()
        {
            var dogs = new Dog[] {
                new Dog(3, "Bobi", Gender.Male),
                new Dog(2, "Balkan", Gender.Male),
                new Dog(1, "Sarah", Gender.Female)
            };
            Console.WriteLine("Average dogs age is {0:F2}!", CalculateAverageAge(dogs));
            var cats = new Cat[]{
                new Cat(2, "Penna", Gender.Female),
                new Cat(1, "Tom", Gender.Male)
            };
            Console.WriteLine("Average cats age is {0:F2}!", CalculateAverageAge(cats));

            var frogs = new Frog[]{
                new Frog(5, "Curly", Gender.Male),
                new Frog(12, "Granny", Gender.Female),
                new Frog(2, "Mamina", Gender.Female)
            };
            Console.WriteLine("Average frogs age is {0:F2}!", CalculateAverageAge(frogs));

            var kittens = new Kitten[]{
                new Kitten(1, "Masha"),
                new Kitten(2, "Macca")
            };
            Console.WriteLine("Average kittens age is {0:F2}!", CalculateAverageAge(kittens));

            var tomcats = new TomCat[]{
                new TomCat(4, "Kockur"),
                new TomCat(14, "Star Kockur")
            };
            Console.WriteLine("Average tomcats age is {0:F2}!", CalculateAverageAge(tomcats));

            

        }

        public static double CalculateAverageAge(Animal[] arrayOfAnimals)
        {
            double avarageAge = arrayOfAnimals.Average(animal => animal.Age);
            return avarageAge;
        }
    }
}
