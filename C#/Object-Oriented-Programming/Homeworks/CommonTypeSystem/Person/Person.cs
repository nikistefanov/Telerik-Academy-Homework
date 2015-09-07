/*Problem 4. Person class
Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
Write a program to test this functionality.*/

namespace Person
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
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
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get 
            { 
                return this.age; 
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than zero");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("{0} is too shy to show his age!", this.Name);
            }

            return string.Format("{0} is {1} years old!", this.Name, this.Age);
        }
    }
}
