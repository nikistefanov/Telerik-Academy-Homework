namespace StudentSystem.Data
{
    using System;
    using System.Data.Entity;

    using StudentSystem.Models;

    public class StudentSystemContext : DbContext, IStudentSystemContext
    {
        public StudentSystemContext() : base("StudentSystemDb")
        {
        }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }        
    }
}
