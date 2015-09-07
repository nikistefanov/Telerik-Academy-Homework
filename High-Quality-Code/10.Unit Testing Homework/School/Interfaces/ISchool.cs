namespace SchoolSystem.Interfaces
{
    using System.Collections.Generic;

    public interface ISchool
    {
        IList<ICourse> Courses { get; }

        void AddCourse(ICourse course);
        void RemoveCourse(ICourse course);

        int GetUniqueStudentID();
    }
}
