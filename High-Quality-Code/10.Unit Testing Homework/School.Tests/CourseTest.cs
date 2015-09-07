namespace SchoolSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SchoolSystem.Objects;
    using SchoolSystem.Interfaces;

    [TestClass]
    public class CourseTest
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

        private Course GetValidCourse()
        {
            var course = new Course("Valid");
            return course;
        }

        [TestMethod]
        public void CreatingCourseShouldSucceedWhenProvidedValidData()
        {
            var course = GetValidCourse();

            Assert.IsInstanceOfType(course, typeof(ICourse), "Creating course failed with valid data.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingCourseShouldThrowArgumentExceptionWhenProvidedEmptyName()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatingCourseShouldThrowArgumentExceptionWhenProvidedTooLongName()
        {
            var tooLongName = new string('a', 101);
            var course = new Course(tooLongName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingCourseShouldThrowArgumentExceptionWhenProvidedNameWithNullValue()
        {
            var course = new Course(null);
        }

        [TestMethod]
        public void AddStudentToCourseShouldSucceedWhenProvidedValidData()
        {
            var student = GetValidStudent();
            var course = GetValidCourse();

            course.AddStudent(student);

            Assert.AreEqual(course.Students[0], student, "Adding one student should add the same object.");
            Assert.AreEqual<int>(1, course.Students.Count,
                string.Format("Number of students in course: {0} is incorrect", course.Students.Count));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddStudentToCourseShouldThrowArgumentNullExceptionWhenProvidedNullStudent()
        {
            var course = GetValidCourse();
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentShouldThrowArgumentOutOfRangeExceptionWhenProvidedMoreThanThirty()
        {
            var course = GetValidCourse();
            School school = GetValidSchool();

            for (int i = 0; i < 31; i++)
            {
                var currStudent = new Student("KTX-" + i, school);
                course.AddStudent(currStudent);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudentShouldThrowArgumentExceptionWhenAddingSameStudent()
        {
            var course = GetValidCourse();
            var student = GetValidStudent();

            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        public void RemoveStudentShouldSucceedWhenProvidedValidData()
        {
            var course = GetValidCourse();
            var student = GetValidStudent();
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual<int>(0, course.Students.Count, "Removing student failed with valid data.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveStudentShouldThrowArgumentExceptionWhenRemovingNotAddedStudent()
        {
            var course = GetValidCourse();
            var student = GetValidStudent();
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveStudentShouldThrowArgumentExceptionWhenRemovingNull()
        {
            var course = GetValidCourse();
            course.RemoveStudent(null);
        }

        [TestMethod]
        public void StudentsPropertyShouldReturnNewListWhenUsingGetter()
        {
            var course = GetValidCourse();
            var students = course.Students;
            var student = GetValidStudent();

            students.Add(student);

            Assert.AreNotEqual(students, course.Students, "Getting students list returned same reference.");
        }
    }
}
