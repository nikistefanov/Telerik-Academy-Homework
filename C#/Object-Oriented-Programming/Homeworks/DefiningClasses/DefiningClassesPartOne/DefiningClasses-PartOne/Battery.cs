using MoblePhones;
using System;

namespace MobilePhones
{
    // battery characteristics (model, hours idle and hours talk)
    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType bt; 


        // Problem 2. Constructors
        public Battery(BatteryType batType)
        {
            this.bt = batType;
        }

        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (model == string.Empty)
                {
                    throw new ArgumentNullException("You have to enter a model for the battery!");
                }
                this.model = value;
            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            private set
            {
                if (hoursIdle < 0)
                {
                    throw new ArgumentException("Hours cannot be negative!");
                }
                if (hoursIdle > 500)
                {
                    throw new ArgumentException("Hours cannot be larger than 500!");
                }
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            private set
            {
                if (hoursTalk < 0)
                {
                    throw new ArgumentException("Hours cannot be negative!");
                }
                if (hoursTalk > 120)
                {
                    throw new ArgumentException("Hours cannot be larger than 120!");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BT
        {
            get
            {
                return this.bt;
            }
            set
            {
                this.bt = value;
            }
        }

        // Problem 4. ToString
        public override string ToString()
        {
            string star = new string('*', 40);
            return String.Format("\n{0}\nBattery model: {1}\nStand-by(hours):{2}\nTalk time(hours): {3}\nBattery Type: {4}\n{0}",star , this.model, this.hoursIdle, this.hoursTalk, this.bt, star);
        }
    }
}
