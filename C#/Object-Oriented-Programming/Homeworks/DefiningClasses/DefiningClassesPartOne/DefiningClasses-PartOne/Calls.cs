//Problem 8. Calls

//Create a class Call to hold a call performed through a GSM.
//It should contain date, time, dialled phone number and duration (in seconds).

using System;


namespace MoblePhones
{
    public class Call
    {
        private DateTime dateAndTime;
        private string dialledPhoneNumber;
        private uint durationInSeconds;

        // Problem 2. Constructors
        public Call(DateTime dateAndTime, string phoneNumber, uint durationInSeconds)
        {
            this.dateAndTime = dateAndTime;
            this.dialledPhoneNumber = phoneNumber;
            this.durationInSeconds = durationInSeconds;
        }

        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            private set
            {
                if (dateAndTime == null)
                {
                    throw new ArgumentNullException("You have to enter a date and time!");
                }
                this.dateAndTime = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            private set
            {
                if (dialledPhoneNumber.Length <= 6)
                {
                    throw new ArgumentException("Enter a valid phone number!");
                }
                this.dialledPhoneNumber = value;
            }
        }

        public uint DurationInSeconds
        {
            get
            {
                return this.durationInSeconds;
            }
            private set
            {
                if (durationInSeconds < 0)
                {
                    throw new ArgumentException("Duration cannot be a negative value!");
                }
                this.durationInSeconds = value;
            }
        }

        // Problem 4. ToString
        public override string ToString()
        {
            return String.Format("Date and time: {0}\nPhone dialled: {1}\nDuration: {2}", this.dateAndTime, this.dialledPhoneNumber, this.durationInSeconds);
        }

    }
}
