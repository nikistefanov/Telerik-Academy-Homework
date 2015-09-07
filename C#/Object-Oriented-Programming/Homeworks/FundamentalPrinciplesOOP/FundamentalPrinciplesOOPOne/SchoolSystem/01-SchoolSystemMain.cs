//Problem 1. School classes

//We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches, a set of disciplines. Students have a name and unique class number. Classes have unique text identifier. Teachers have a name. Disciplines have a name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SchoolSystemMain
    {
        static void Main()
        {
            string star = new string('*', 40);
            var listOfStudents = new List<Student>() {
                new Student ("Bob", "Hoohev","5554578"),
                new Student ("Horhe", "Jokev", "154587"),
                new Student ("Mimeto", "Simetova", "154747"),
                new Student ("Ivanka", "Gerginova", "5558412"),
                new Student ("Hoanito", "Ignatovic", "9845247"),
                new Student ("Alona", "O'Brail", "445588"),
                new Student ("Maria", "Gabana", "857496"),
                new Student ("Francoa", "Galaga", "154578"),
                new Student ("Cristine", "Lubenova", "134579"),
                new Student ("Lubov", "Nadejdova", "555875")
            };
            Console.WriteLine("Print all the students:");
            Console.WriteLine(star);
            foreach (var student in listOfStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine(star);

            var listOfTeachers = new List<Teacher>();
            listOfTeachers.Add(new Teacher("Ivanka", "Dimitrova"));
            listOfTeachers[0].AddDiscipline("PIK", 2, 1);
            listOfTeachers[0].AddDiscipline("CSharp", 6, 6);
            listOfTeachers.Add(new Teacher("Dori", "Annova"));
            listOfTeachers[1].AddDiscipline("OS", 7, 7);
            listOfTeachers[1].AddDiscipline("OOP", 21, 15);
            listOfTeachers[1].AddDiscipline("Maths", 19, 17);

            Console.WriteLine("Print all the teachers:");
            Console.WriteLine(star);
            foreach (var teacher in listOfTeachers)
            {
                Console.WriteLine(teacher.ToString());
            }
            Console.WriteLine(star);

            var firstClass = new Class("Boombastick");
            foreach (var teacher in listOfTeachers)
            {
                if (teacher.Disciplines.Count < 3)
                {
                    firstClass.AddTeacher(teacher);
                }
            }

            foreach (var student in listOfStudents)
            {
                if (student.ID.Contains("555"))
                {
                    firstClass.AddStudent(student);
                }
            }
            Console.WriteLine("Print the class:");
            Console.WriteLine(firstClass);

        }
    }
}
