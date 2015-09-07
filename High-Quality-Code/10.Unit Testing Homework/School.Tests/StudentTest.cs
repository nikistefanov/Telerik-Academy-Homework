namespace SchoolSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem.Objects;
    using SchoolSystem.Interfaces;

    [TestClass]
    public class StudentTest
    {
        private Student GetValidStudent()
        {
            var school = GetValidSchool();
            var student = new Student("Valid", school);

            return student;
        }

        private School GetValidSchool()
        {
            var school = new School("Valid");
            return school;
        }

        [TestMethod]
        public void CreatingStudentShouldSucceedWhenProvidedValidData()
        {    
            var student = GetValidStudent();

            Assert.IsInstanceOfType(student, typeof(IStudent));
            Assert.IsNotNull(student.ID, "Student cannot have ID equal to null.");
            Assert.IsNotNull(student.Name, "Student cannot have name equal to null.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingStudentShouldTrowArgumentExceptionWhenGivenNameWithNullValue()
        {
            var school = GetValidSchool();
            var student = new Student(null, school);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingStudentShouldThrowArgumentExceptionWhenGivenEmptyName()
        {
            var school = GetValidSchool();
            var student = new Student(string.Empty, school);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatingStudentShouldThrowArgumentOutOfRangeExceptionWhenGivenTooLongName()
        {
            var school = new School("FELS");
            var tooLongName = new string('a', 101);
            var student = new Student(tooLongName, school);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingStudentShouldThrowArgumentNullExceptionWhenGivenSchoolWithNullValue()
        {
            var student = new Student("Marry", null);
        }

        [TestMethod]
        public void StudentsShouldHaveDifferentIDsIfInOneSchool()
        {
            var school = new School("FELS");

            var firstStudent = new Student("John", school);
            var secondStudent = new Student("Marry", school);

            Assert.AreNotEqual(firstStudent.ID, secondStudent.ID, 
                "Students in one school cannot have same ID.");
        }

        [TestMethod]
        public void StudentsCanHaveSameIDIfInDifferentSchools()
        {
            var firstSchool = new School("FELS");
            var secondSchool = new School("FGLS");

            var studentInFirstSchool = new Student("Sophie", firstSchool);
            var studentInSecondSchool = new Student("Leonardo", secondSchool);

            Assert.AreEqual(studentInFirstSchool.ID, studentInSecondSchool.ID, 
                "Adding first students in different schools should give them same ID.");
        }
    }
}
