namespace StudentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    class Students
    {
        private string firstName;
        private string lastName;
        private string fullName;
        private int age;
        private int facultyNumber;
        private string mobile;
        private string email;
        private List<int> marks = new List<int>();
        private int groupNumber;

        public Students(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Students(string firstName, string lastName, int age, int fNumber, string mobile, string email, int mark, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = fNumber;
            this.Mobile = mobile;
            this.Email = email;
            this.Marks.Add(mark);
            this.GroupNumber = group;
        }

        public string FirstName
        {
            get 
            {
                return this.firstName;
            }
            private set 
            {
                this.firstName = value;
            }
        }
        
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }
        
        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            private set
            {
                this.facultyNumber = value;
            }
        }

        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            set
            {
                foreach (char symbol in value)
                {
                    if (!char.IsDigit(symbol))
                    {
                        if (symbol == '+')
                        {
                            continue;
                        }
                        throw new ArgumentException("Mobile number cannot contains charachters!");
                    }
                    this.mobile = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Please enter a valid e-mail adress");
                }
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            private set
            {
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                this.groupNumber = value;
            }
        }

        public string Info()
        {
            var builder = new StringBuilder();
            builder.AppendLine(new string('=', 40));
            builder.AppendLine("Name: " + this.FirstName + " " + this.LastName);
            builder.AppendLine("Age: " + this.Age);
            builder.AppendLine("Faculty number: " + this.FacultyNumber);
            builder.AppendLine("Mobile: " + this.Mobile);
            builder.AppendLine("E-mail: " + this.Email);
            builder.AppendLine("Marks: " + string.Join(", ", this.Marks));
            builder.AppendLine("Group: " + this.GroupNumber);
            builder.AppendLine(new string('=', 40));
            return builder.ToString();
        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName + " Age:" + this.Age);
        }
    }
}
