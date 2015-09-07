/*Problem 1. Student class

Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.*/


namespace StudentClass
{

    using System;

    using StudentClass.Enums;

    public class StartPoint
    {
        static void Main()
        {
            var firstStudent = new Student("Gosho", "Brigadirov", "Kirov", 554755, "2 Pencho street", "+3598875423664",
                "gogoton@abv.bg", 5, Specialitiy.Engineering, University.TehnicalUniversity, Faculty.Mathematic);
            var secondStudent = new Student("Evdokiq", "Gusheva", "Musheva", 558899, "3 Nanadolnishte blv.", "029408751",
                "musheva@gmail.com", 4, Specialitiy.Biology, University.UNSS, Faculty.Biologic);
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine();
            Console.WriteLine("{0} hash code is {1}",firstStudent.FirstName, firstStudent.GetHashCode());
            Console.WriteLine("{0} hash code is {1}",secondStudent.FirstName ,secondStudent.GetHashCode());

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Coping:");
            Console.WriteLine(new string('*', 40));
            var AntoanCopy = firstStudent.Clone();
            Console.WriteLine(AntoanCopy);

            Console.WriteLine(new string('*', 40));
            Console.WriteLine("Comparing");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(firstStudent.CompareTo(secondStudent));
        }
    }
}
