namespace SchoolSystem
{
    using System;

    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;

        public Discipline(string nameOfDiscipline, int numOfLectures, int numOfExercises)
        {
            this.Name = nameOfDiscipline;
            this.NumberOfLectures = numOfLectures;
            this.NumberOfExercises = numOfExercises;
        }

        public Discipline(string nameOfDiscipline, int numOfLectures, int numOfExercises, string comment)
            : this(nameOfDiscipline, numOfLectures, numOfExercises)
        {
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name of the discipline cannot be an empty text!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name of the discipline cannot be less than 2 symbols!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set 
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Lectures cannot be less than 1");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Exercises cannot be less than 1");
                }
                this.numberOfExercises = value;
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

        public override string ToString()
        {
            return string.Format("Discipline \"{0}\" has {1} lectures and {2} excercises.", this.Name, this.NumberOfLectures, this.NumberOfLectures, this.NumberOfExercises);
        }

        
    }
}
