//Problem 3. First before last
//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.
//Problem 4. Age range
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
//Problem 5. Order students
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.
//Problem 9. Student groups
//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.
//Problem 10. Student groups extensions
//Implement the previous using the same query expressed with extension methods.
//Problem 11. Extract students by email
//Extract all students that have email in abv.bg.
//Use string methods and LINQ.
//Problem 12. Extract students by phone
//Extract all students with phones in Sofia.
//Use LINQ.
//Problem 13. Extract students by marks
//Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
//Use LINQ.
//Problem 14. Extract students with two marks
//Write down a similar program that extracts the students with exactly two marks "2".
//Use extension methods.

namespace StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentMain
    {
        static void Main()
        {
            var studentsArray = new Students[] {
                new Students ("Ivan", "Atanasov", 18),
                new Students ("Maria", "Marianova", 27),
                new Students ("Ivanka", "Zafirova", 22),
                new Students ("Gosho", "Petrov", 13),
                new Students ("Karolina", "Cvetkova", 33),
                new Students ("Jasmin", "Borisova", 25)
            };
            
            Console.WriteLine("Those are all the students from Students[]");
            Console.WriteLine(new string('=', 40));
            foreach (var student in studentsArray)
            {
                Console.WriteLine(student);
            }
            
            //Problem 3
            var sortedStudentsByFirstAndLastName = from student in studentsArray
                                                   where student.FirstName.CompareTo(student.LastName) < 0
                                                   select student;
                
            //students.Where(student => student.FirstName.CompareTo(student.LastName) < 0);
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("This is from Problem 3.");
            Console.WriteLine(new string('=', 40));
            foreach (var student in sortedStudentsByFirstAndLastName)
            {
                Console.WriteLine(student);
            }
            
            //Problem 4
            var sortedStudentsByAge = from student in studentsArray
                                      where student.Age >= 18 && student.Age <= 25
                                      select student;
                
            //students.Where(student => student.Age >= 18 && student.Age <= 25);
            Console.WriteLine(new string('=', 40)); 
            Console.WriteLine("This is from Problem 4.");
            Console.WriteLine(new string('=', 40));
            foreach (var student in sortedStudentsByAge)
            {
                Console.WriteLine(student);
            }
            
            //Problem 5. 
            //Using lambda expressions
            var sortedStudentsWithLambda = studentsArray
                .OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName);
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("This is from Problem 5. Lambda expressions");
            Console.WriteLine(new string('=', 40));
            foreach (var student in sortedStudentsWithLambda)
            {
                Console.WriteLine(student);
            }
            //Using LINQ
            var sortedStudentsWithLINQ = from student in studentsArray
                                         orderby student.FirstName descending, student.LastName descending
                                         select student;
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("This is from Problem 5. LINQ");
            Console.WriteLine(new string('=', 40));
            foreach (var student in sortedStudentsWithLINQ)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine(new string('=', 40));

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Now we are starting from Problem 9!!!");
            Console.ResetColor();
            Console.WriteLine();

            //Problem 9.
            var studentsList = new List<Students>() 
            {
                new Students ("Gog", "Gogov", 24, 77859, "+3598945252484", "gog@abv.bg", 5, 1),
                new Students ("Ivan", "Atanasov", 18, 77860, "+35989895421", "vanio_bosso@yahoo.com", 3, 1),
                new Students ("Maria", "Marianova", 27, 886475, "+3598823343554", "malkoto_mime_s_loshoto_ime@abv.bg", 6, 2),
                new Students ("Karolina", "Cvetkova", 33, 886478, "08994457878", "kara_l@ina.bg", 2, 2),
                new Students ("Atanas", "Petrov", 13, 445248, "08794402", "nasko_rog@abv.bg", 3, 2)
            };
            Console.WriteLine("Those are the students from List<Students>");
            foreach (var student in studentsList)
            {
                Console.WriteLine(student.Info());
            }


            //Problem 10. LINQ
            var sortedStudentsListWithLINQ = from student in studentsList
                                     where student.GroupNumber == 2
                                     orderby student.FirstName
                                     select student;
            Console.WriteLine("This is from Problem 10. LINQ");
            foreach (var student in sortedStudentsListWithLINQ)
            {
                Console.WriteLine(student.Info());
            }

            //Problem 10. Lambda
            var sortedStudentsWithExtension = studentsList.Where(student => student.GroupNumber == 2)
                                                          .OrderBy(student => student.FirstName);
            Console.WriteLine("This is from problem 10. Extension methods:");
            foreach (var student in sortedStudentsWithExtension)
            {
                Console.WriteLine(student.Info());
            }

            //Problem 11. LINQ
            var extractAbvEmailsWithLINQ = from student in studentsList
                                  where student.Email.Contains("abv.bg")
                                  select student;
            Console.WriteLine("This is from Problem 11. LINQ");
            Console.WriteLine(new string('=', 40));
            foreach (var student in extractAbvEmailsWithLINQ)
            {
                Console.WriteLine(student.Email + " owned by " + student.FullName);
            }
            
            //Problem 12. I've changed it a bit. Extracting students with Telenor's number
            var extractTelenorsMobiles = from student in studentsList
                                         where student.Mobile.Contains("+35989") || student.Mobile.Contains("089")
                                         select student;
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("This is from problem 12. Chaged a bit (see comment):");
            Console.WriteLine(new string('=', 40));
            foreach (var student in extractTelenorsMobiles)
            {
                Console.WriteLine(student.Mobile + " owned by " + student.FullName);
            }

            //Problem 13.
            //Adding some marks using random method
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                foreach (var student in studentsList)
                {
                    student.Marks.Add(rnd.Next(2, 7));
                }
            }
            var extractStudentsWithA = from student in studentsList
                                     where student.Marks.Contains(6)
                                     select new { FullName = student.FullName, Marks = student.Marks };
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("This is from problem 13:");
            Console.WriteLine(new string('=', 40));

            foreach (var student in extractStudentsWithA)
            {
                Console.Write(student.FullName + "! ");
                Console.WriteLine("Marks: {0}", string.Join(", ", student.Marks));
            }
            Console.WriteLine(new string('=', 40));

            //Problem 14.
            var extractStudentsWithF = studentsList.Where(student => student.Marks.FindAll(mark => mark == 2).Count == 2)
                .Select(student => new { Name = student.FullName, MarksList = student.Marks });
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("This is from problem 14:");
            Console.WriteLine(new string('=', 40));
            foreach (var student in extractStudentsWithF)
            {
                Console.Write(student.Name + "! ");
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
            }
           
        }
    }
}
