
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractise.Models
{
    using System;

    using ExamPractise.Interfaces;
   
    public class Teacher : ITeacher
    {

        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }
        public string Name { get; set; }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            //Teacher: Name=(teacher name); Courses=[(course names – comma separated)]
            string format = "Teacher: Name={0}";
            
            if (this.courses.Count > 0)
            {
                format += "; Courses=[{1}]";
            }

            var courseNames = this.courses.Select(x => x.Name);
            string result = string.Format(format, this.Name, string.Join(", ", courseNames));

            return result;
        }
    }
}
