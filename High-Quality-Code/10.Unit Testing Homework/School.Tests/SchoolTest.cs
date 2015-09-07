namespace SchoolSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SchoolSystem.Interfaces;
    using SchoolSystem.Objects;

    [TestClass]
    public class SchoolTest
    {
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
        public void CreatingSchoolShouldSucceedWhenProvidedValidData()
        {
            var school = new School("Valid");

            Assert.IsInstanceOfType(school, typeof(ISchool),
                "Creating new School failed with valid data.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingSchoolShouldThrowArgumentExceptionWhenProvidedEmptyName()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreatingSchoolShouldThrowArgumentOutOfRangeExceptionWhenProvidedTooLongName()
        {
            var tooLongName = new string('a', 101);
            var school = new School(tooLongName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatingSchoolShouldThrowArgumentExceptionWhenProvidedNameWithValueNull()
        {
            var school = new School(null);
        }

        [TestMethod]
        public void AddCourseShouldSucceedWhenProvidedValidData()
        {
            var school = GetValidSchool();
            var course = GetValidCourse();

            school.AddCourse(course);

            Assert.AreEqual<int>(1, school.Courses.Count,
                string.Format("Courses count is: {0} which is incorrect.", school.Courses.Count));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddCourseShouldThrowArgumentNullExceptionWhenProvidedCourseWithValueNull()
        {
            var school = GetValidSchool();

            school.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddCourseShouldThrowArgumentNullExceptionWhenAddingSameCourse()
        {
            var school = GetValidSchool();
            var course = GetValidCourse();

            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        public void RemoveCourseShouldSucceedWhenProvidedValidData()
        {
            var school = GetValidSchool();
            var course = GetValidCourse();

            school.AddCourse(course);
            school.RemoveCourse(course);

            Assert.AreEqual<int>(0, school.Courses.Count,
                string.Format("Courses count is: {0} which is incorrect.", school.Courses.Count));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveCourseShouldThrowArgumentNullExceptionWhenProvidedCourseWithValueNull()
        {
            var school = GetValidSchool();
            school.RemoveCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveCourseShouldThrowArgumentExceptionWhenRemovingNotAddedCourse()
        {
            var school = GetValidSchool();
            var course = GetValidCourse();

            school.RemoveCourse(course);
        }

        [TestMethod]
        public void RemoveCourseShouldRemoveRightCourseWhenRemovingFromMultiple()
        {
            var validNames = new string[3] { "Java", "C#", "C++" };
            var school = GetValidSchool();
            var firstCourse = new Course(validNames[0]);
            var secondCourse = new Course(validNames[1]);
            var thirdCourse = new Course(validNames[2]);

            school.AddCourse(firstCourse);
            school.AddCourse(secondCourse);
            school.AddCourse(thirdCourse);
            school.RemoveCourse(firstCourse);

            for (int i = 0; i < school.Courses.Count; i++)
            {
                var currCourse = school.Courses[i];
                Assert.AreNotEqual(firstCourse, currCourse, "Removing course failed.");
            }
        }

        [TestMethod]
        public void CoursesPropertyShouldReturnNewListWhenUsingGetter()
        {
            var school = GetValidSchool();
            var courses = school.Courses;
            var course = GetValidCourse();

            courses.Add(course);

            Assert.AreNotEqual(courses, course.Students, "Getter returned same reference.");
        }

        [TestMethod]
        public void GetUniqueStudentIDShouldReturnDifferentValue()
        {
            var school = GetValidSchool();
            var ids = new int[10];

            for (int i = 0; i < ids.Length; i++)
            {
                ids[i] = school.GetUniqueStudentID();
            }

            for (int i = 0; i < ids.Length; i++)
            {
                var currID = ids[i];
                for (int j = i + 1; j < ids.Length; j++)
                {
                    var nextId = ids[j];
                    Assert.AreNotEqual<int>(currID, nextId, "Found two equal ID-s which is incorrect.");
                }
            }
        }
    }
}
