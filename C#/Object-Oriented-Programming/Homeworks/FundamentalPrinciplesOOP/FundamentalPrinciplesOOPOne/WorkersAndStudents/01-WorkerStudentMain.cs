//Problem 2. Students and workers

//Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace WorkersAndStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class WorkerStudentMain
    {
        static void Main()
        {
            var listOfStudents = new List<Student>() {
                new Student ("Bob", "Hoohev", 6),
                new Student ("Horhe", "Jokev", 5),
                new Student ("Mimeto", "Simetova", 4),
                new Student ("Ivanka", "Gerginova", 2),
                new Student ("Hoanito", "Ignatovic", 6),
                new Student ("Alona", "O'Brail", 5),
                new Student ("Maria", "Gabana", 3),
                new Student ("Francoa", "Galaga", 4),
                new Student ("Cristine", "Lubenova", 3),
                new Student ("Lubov", "Nadejdova", 2)
            };
            Console.WriteLine("Sorted!");
            Console.WriteLine(new string('=', 60));
            var listOfStudentsOrdered = listOfStudents.OrderBy(student => student.Grade);
            foreach (var student in listOfStudentsOrdered)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Sorted!");
            Console.WriteLine(new string('=', 60));
            var listOfWorkers = new List<Worker>() {
                new Worker ("Andrei", "Lqpchev", 125, 5),
                new Worker ("Alexandar", "Malinov", 200, 8),
                new Worker ("Evlogi", "Georgiev", 133, 12),
                new Worker ("Maria", "Ignatova", 87, 7),
                new Worker ("Carica", "Ioana", 90, 6),
                new Worker ("Sharo", "Hoohev", 300, 4),
                new Worker ("Todor", "Botev", 120, 8),
                new Worker ("Todor", "Alexandrov", 120, 6),
                new Worker ("Rich", "Richerson", 760, 3),
                new Worker ("Knqz", "Boris", 350, 10),
            };
            var listOfWorkersOrdered = listOfWorkers.OrderByDescending(worker => worker.MoneyPerHour());
            foreach (var worker in listOfWorkersOrdered)
            {
                Console.WriteLine(worker.ToString());
            }
            // merge
            var listOfStudentsAndWorkers = new List<Human>();
            listOfStudentsAndWorkers.AddRange(listOfStudents);
            listOfStudentsAndWorkers.AddRange(listOfWorkers);
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("Merged!");
            Console.WriteLine(new string('=', 60));
            var sortedPeople = listOfStudentsAndWorkers.OrderBy(person => person.FirstName).ThenBy(person => person.LastName);
            foreach (var person in sortedPeople)
            {
                Console.WriteLine(string.Format(person.FirstName + " " + person.LastName));
            }
            Console.WriteLine(1);
        }
    }
}
