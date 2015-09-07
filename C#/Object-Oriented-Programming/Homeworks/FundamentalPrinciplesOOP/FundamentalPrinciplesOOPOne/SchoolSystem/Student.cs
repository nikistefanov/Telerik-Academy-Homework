namespace SchoolSystem
{
    using System;
    using System.Linq;
    
    public class Student : People, ICommentable
    {
        private string iD;
        private string comment;
        
        public Student(string firstName, string lastName, string id)
            : base(firstName, lastName)
        {
            this.ID = id;
        }

        public Student(string firstName, string lastName, string id, string comment)
            : base(firstName, lastName)
        {
            this.ID = id;
            this.Comment = comment;
        }

        public string ID
        {
            get
            {
                return this.iD;
            }
            private set
            {
                if (value.Any(ch => !char.IsDigit(ch)))
                {
                    throw new ArgumentException("Student's class number must contains only digits!");
                }
                if (value.Length < 6)
                {
                    throw new ArgumentOutOfRangeException("Class number cannot be less than 6 digits!");
                }
                this.iD = value;
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

        public string ShowComment()
        {
            if (string.IsNullOrEmpty(this.Comment))
            {
                return "There's no comments.";
            }
            return "Comment: " + this.Comment;
        }

        public override string GetName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} | ID: {2}", this.FirstName, this.LastName, this.ID);
        }


        
    }
}
