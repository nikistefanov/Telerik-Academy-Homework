namespace AnimalSystem
{
    using System;
    
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Gender sex;

        protected Animal(int age, string name, Gender sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public Gender Sex
        {
            get 
            { 
                return this.sex; 
            }
            private set 
            { 
                this.sex = value; 
            }
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
                    throw new ArgumentException("You must enter a name!");
                }
                this.name = value; 
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
                if (value < 0)
                {
                    throw new ArgumentException("Age must be greater than 0!");
                }
                this.age = value;
            }
        }

        public abstract string Sound();
    }
}
