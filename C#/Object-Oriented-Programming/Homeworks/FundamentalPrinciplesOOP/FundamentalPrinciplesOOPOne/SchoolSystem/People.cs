namespace SchoolSystem
{
    using System;

    public abstract class People
    {
        private string firstName;
        private string lastName;

        public People(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be an empty text!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name cannot be less than 2 symbols!");
                }
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be an empty text!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name cannot be less than 2 symbols!");
                }
                this.lastName = value;
            }
        }

        public abstract string GetName();
    }
}
