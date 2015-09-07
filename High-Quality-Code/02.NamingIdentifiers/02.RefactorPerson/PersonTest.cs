namespace RefactorPerson
{
    using System;

    public class PersonTest
    {
        public static void Main()
        {
            Console.Write("Please, enter integer number: ");
            int age = int.Parse(Console.ReadLine());
            Person somePerson = CreatePerson(age);
            Console.WriteLine(somePerson);
        }

        public static Person CreatePerson(int age)
        {

            Person person = new Person();
            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Djordjano";
                person.Gender = Gender.StrongMan;
            }
            else
            {
                person.Name = "Mimeto";
                person.Gender = Gender.SexyWoman;
            }

            return person;
        }
    }
}
