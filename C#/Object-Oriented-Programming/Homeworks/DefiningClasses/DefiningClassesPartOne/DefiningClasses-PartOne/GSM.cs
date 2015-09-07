using MoblePhones;
using System;
using System.Collections.Generic;
using System.Text;


namespace MobilePhones
{
    // mobile phone device: model, manufacturer, price, owner, battery characteristics and display characteristics.
    public class GSM
    {
        private const decimal PRICE_PER_MINUTE = 0.37M;


        // Problem 6. Static field
        // Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        public static GSM iPhone4S = new GSM("iPhone 4S", "Apple", 450, "John", new Battery(BatteryType.LiPoly), new Display(3.5), ColorOfPhones.Black);


        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery batteryInfo;
        private Display displayInfo;
        private ColorOfPhones colorPhone;
        private List<Call> callHistory;


        // Problem 2. Constructors
        // Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery batteryInfo, Display displayInfo, ColorOfPhones colorPhone)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.batteryInfo = batteryInfo;
            this.displayInfo = displayInfo;
            this.colorPhone = colorPhone;
            this.CallHistory = new List<Call>();
        }

        // Problem 9. Call history
        // Add a property CallHistory in the GSM class to hold a list of the performed calls.
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                this.callHistory = value;
            }
        }

        // Problem 10. Add/Delete calls
        // Add methods in the GSM class for adding and deleting calls from the calls history.
        // Add a method to clear the call history.
        
        public List<Call> AddCalls(Call callToAdd)
        {
            
            this.callHistory.Add(callToAdd);
            return this.callHistory;
        }

        public List<Call> DeleteCalls(Call callToRemove)
        {
            
            this.callHistory.Remove(callToRemove);
            return this.callHistory;
        }

        public List<Call> ClearCalls()
        {
            this.callHistory.Clear();
            return this.callHistory;
        }

        // Problem 11. Call price
        // Add a method that calculates the total price of the calls in the call history.
        // Assume the price per minute is fixed and is provided as a parameter.
        public decimal TotalPriceOfCalls()
        {
            decimal totalPrice = 0;
            decimal pricePerSecond = PRICE_PER_MINUTE / 60;
            foreach (var call in callHistory)
            {
                decimal callPrice = pricePerSecond * call.DurationInSeconds;
                totalPrice += callPrice;
            }
            return totalPrice;
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
                    throw new ArgumentNullException("You have to enter a model for the phone!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (manufacturer == string.Empty)
                {
                    throw new ArgumentNullException("You have to enter a manufacturer for the phone!");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (price < 0)
                {
                    throw new ArgumentException("Price cannot be a negative number!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                if (owner == string.Empty)
                {
                    throw new ArgumentException("You have to enter a name for the owner!");
                }
                this.owner = value;
            }
        }

        public Battery BatteryInfo
        {
            get
            {
                return this.batteryInfo;
            }
            private set
            {
                this.batteryInfo = value;
            }
        }

        public Display DisplayInfo
        {
            get
            {
                return this.displayInfo;
            }
            private set
            {
                this.displayInfo = value;
            }
        }

        public ColorOfPhones Color
        {
            get
            {
                return this.colorPhone;
            }
            private set
            {
                this.colorPhone = value;
            }
        }

        // Problem 4. ToString
        //Add a method in the GSM class for displaying all information about it.
        //Try to override ToString().
        string GSMinformation;
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Model: {0}\n", this.model);
            builder.AppendFormat("Manufacturer: {0}\n", this.manufacturer);
            builder.AppendFormat("Price: {0}\n", this.price);
            builder.AppendFormat("Owner: {0}\n", this.owner);
            builder.AppendFormat("Battery: {0}\n", this.batteryInfo);
            builder.AppendFormat("Display: {0}\n", this.displayInfo);
            builder.AppendFormat("Color: {0}\n", this.colorPhone.ToString());
            builder.AppendLine();
            GSMinformation = builder.ToString();
            return GSMinformation;
        }
    }
}
