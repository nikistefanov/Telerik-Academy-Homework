namespace ExamPractise.Models
{
    using System;

    using ExamPractise.Interfaces;

    class LocalCourse : Course, ILocalCourse, ICourse
    {
        public LocalCourse(string name, ITeacher teacher, string lab)
            : base (name, teacher)
        {
            this.Lab = lab;
        }
        
        public string Lab { get; set; }

        public override string ToString()
        {
            return string.Format("{0}; Lab={1}", base.ToString(), this.Lab);
        }
    }
}
