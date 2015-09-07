namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class : ICommentable
    {
        private HashSet<Teacher> teachers;
        private HashSet<Student> students;
        private string textID;
        private string comment;

        public Class(string textID)
        {
            this.TextID = textID;
            this.teachers = new HashSet<Teacher>();
            this.students = new HashSet<Student>();
        }

        public Class(string textID, string comment)
        {
            this.TextID = textID;
            this.Comment = comment;
            this.teachers = new HashSet<Teacher>();
            this.students = new HashSet<Student>();
            
        }

        public string TextID
        {
            get
            {
                return this.textID;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The ID of the class cannot be an empty text!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("ID cannot contains less than 3 symbols!");
                }
                this.textID = value;
            }
        }

        private HashSet<Teacher> Teachers
        {
            get
            {
                return new HashSet<Teacher>(this.teachers);
            }
        }

        private HashSet<Student> Students
        {
            get
            {
                return new HashSet<Student>(this.students);
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Comment cannot be an empty text!");
                }
                this.comment = value;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public string ShowComment()
        {
            if (string.IsNullOrEmpty(this.Comment))
            {
                return "There's no comments.";
            }
            return "Comment: " + this.Comment;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(new string('=', 40));
            builder.AppendLine(string.Format("Class name: {0}", this.TextID));
            builder.AppendLine(new string('=', 40));
            builder.AppendLine("Teachers:");
            builder.AppendLine(new string('=', 40));
            foreach (var teacher in this.Teachers)
            {
                builder.AppendLine(teacher.GetName());
            }
            builder.AppendLine(new string('=', 40));
            builder.AppendLine("Students:");
            builder.AppendLine(new string('=', 40));
            foreach (var student in this.Students)
            {
                builder.AppendLine(student.GetName());
            }
            builder.Append(new string('=', 40));
            return builder.ToString();
        }
    }
}
