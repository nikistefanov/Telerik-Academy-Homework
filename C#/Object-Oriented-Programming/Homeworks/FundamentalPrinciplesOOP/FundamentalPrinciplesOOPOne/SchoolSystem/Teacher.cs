namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People, ICommentable
    {
        private List<Discipline> disciplines;
        private string comment;

        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string firstName, string lastName, string comment)
            : base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();
            this.Comment = comment;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.disciplines);
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

        public void AddDiscipline(string name, int numberOfLectures, int numberOfExcercises)
        {
            var discipline = new Discipline(name, numberOfLectures, numberOfExcercises);
            this.disciplines.Add(discipline);

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

            return string.Format("{0} {1} has {2} set of disciplines:\n{3}\n", this.FirstName,this.LastName , this.Disciplines.Count, string.Join("\n", this.Disciplines));
        }

        
    }
}
