namespace SchoolSystem.Objects
{
    using System;

    using Common;
    using Interfaces;

    public class Student : IStudent
    {
        private string name;
        private int id;

        public Student(string name, ISchool schoolEnrolledIn)
        {
            this.Name = name;
            Validator.CheckIfNull<ISchool>(schoolEnrolledIn);
            this.ID = schoolEnrolledIn.GetUniqueStudentID();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfEmptyStringOrNull(value, "Name");
                Validator.CheckIfValueInRange(value.Length, 1, 100, "Name");
                this.name = value;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }

            private set
            {
                Validator.CheckIfNull<int>(value);
                Validator.CheckIfValueInRange(value, 10000, 99999, "ID");

                this.id = value;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as Student;
            return (this.ID == other.ID) && (this.Name == other.Name);
        }
    }
}
