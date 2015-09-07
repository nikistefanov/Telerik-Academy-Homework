namespace WorkersAndStudents
{
    using System;

    public class Worker : Human
    {
        private const int WORK_DAYS_PER_WEEK = 5;
        
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int hoursPerDay)
            : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = hoursPerDay;
            this.MoneyPerHour();
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary must be a positive number!");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours must be a positive number!");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = (decimal)((this.WeekSalary / WORK_DAYS_PER_WEEK) / this.WorkHoursPerDay);
            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} --> Money per hour: {2:C2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
