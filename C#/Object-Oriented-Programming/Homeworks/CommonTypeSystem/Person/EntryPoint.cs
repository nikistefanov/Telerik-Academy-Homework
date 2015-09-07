namespace Person
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            Person firstPerson = new Person("Harrison");
            Person secondPerson = new Person("Johns", 55);

            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
