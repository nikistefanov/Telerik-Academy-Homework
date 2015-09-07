namespace ExamPractise.Models
{
    using System;
    using System.Collections.Generic;

    using ExamPractise.Interfaces;
    using System.Text;

    public abstract class Course : ICourse
    {
        private ICollection<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public string Name { get; set; }

        public ITeacher Teacher { get; set; }


        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            //(course type): Name=(course name); Teacher=(teacher name); Topics=[(course topics – comma separated)]; Lab=(lab name – when applicable); Town=(town name – when applicable);
            string result = string.Format("{0}: Name={1}", this.GetType().Name, this.Name);

            if (this.Teacher != null)
            {
                result += string.Format("; Teacher={0}", this.Teacher.Name);
            }



            if (this.topics.Count > 0)
            {
                result += string.Format("; Topics=[{0}]", string.Join(", ", this.topics));
            }


            return result;
        }
    }
}
