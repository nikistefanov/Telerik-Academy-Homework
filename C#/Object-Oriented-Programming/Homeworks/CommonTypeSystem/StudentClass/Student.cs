//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.

namespace StudentClass
{
    using System;
    using System.Linq;

    using StudentClass.Enums;

    class Student : ICloneable, IComparable<Student>, IComparable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string adress;
        private string mobileNumber;
        private string email;
        private int course;
        private Specialitiy speciality;
        private University university;
        private Faculty faculty;


        public Student(string first, string middle, string last, int ssn, string adress, string phone,
            string email, int course, Specialitiy speciality, University university, Faculty faculty)
        {
            this.FirstName = first;
            this.MiddleName = middle;
            this.LastName = last;
            this.Ssn = ssn;
            this.Adress = adress;
            this.PhoneNumber = phone;
            this.Email = email;
            this.Course = course;
            this.speciality = speciality;
            this.university = university;
            this.faculty = faculty;
        }

        public int Course
        {
            get { return course; }
            set
            {
                if (value < 0) { throw new ArgumentNullException("This course number must be non-negative."); }
                course = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (!value.Contains('@') || !value.Contains('.')) { throw new ArgumentNullException("This is not valid email adress."); }
                if (value.Length < 6) { throw new ArgumentNullException("The email adress must be at least with one 6 symbols"); }
                email = value;
            }
        }
        public string PhoneNumber
        {
            get { return mobileNumber; }
            set
            {
                if (value == String.Empty) { throw new ArgumentNullException("This phone number must be at least with one symbol"); }
                mobileNumber = value;
            }
        }
        public string Adress
        {
            get { return adress; }
            set
            {
                if (value == String.Empty) { throw new ArgumentNullException("This adress must be at least with one symbol"); }
                adress = value;
            }
        }
        public int Ssn
        {
            get { return ssn; }
            set
            {
                if (value < 0) { throw new ArgumentNullException("This ssn must be non-negative."); }
                ssn = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == String.Empty) { throw new ArgumentNullException("This value must be at least with one symbol"); }
                lastName = value;
            }
        }
        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (value == String.Empty) { throw new ArgumentNullException("This value must be at least with one symbol"); }
                middleName = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == String.Empty) { throw new ArgumentNullException("This value must be at least with one symbol"); }
                firstName = value;
            }
        }

        public override string ToString()
        {
            return "First name:" + this.FirstName +
                "\nSecond name:" + this.MiddleName +
                "\nThird name:" + this.LastName +
                "\nSSN:" + this.Ssn +
                "\nAdress:" + this.Adress +
                "\nPhone number:" + this.PhoneNumber +
                "\nEmail:" + this.Email +
                "\nCourse:" + this.Course +
                "\nSpeciality:" + this.speciality +
                "\nUniversity:" + this.university +
                "\nFaculty:" + this.faculty;
        }

        public override bool Equals(object obj)
        {
            Student other = (Student)obj;
            if (obj == null)
            {
                return false;
            }
            if (other.Ssn == this.Ssn)
            {
                return true;
            }
            return false;
        }


        public static bool operator ==(Student a, Student b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !a.Equals(b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.ssn.GetHashCode();
                return result;
            }
        }

        //2.
        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Adress, this.PhoneNumber,
                        this.Email, this.Course, this.speciality, this.university, this.faculty);
        }

        //3.
        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            if (this.Ssn.CompareTo(other.Ssn) != 0)
            {
                return this.Ssn.CompareTo(other.Ssn);
            }
            return 0;
        }



        public int CompareTo(Object obj)
        {
            if (obj != null && !(obj is Student))
            {
                throw new ArgumentException("Object must be of type Student.");
            }

            return CompareTo(obj as Student);
        }
    }
}
