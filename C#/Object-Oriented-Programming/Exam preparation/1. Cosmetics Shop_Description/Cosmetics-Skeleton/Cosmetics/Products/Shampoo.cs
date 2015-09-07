namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;
        private decimal price;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, gender)
        {
            this.Milliliters = milliliters;
            this.Price = price;
            this.Usage = usage;
        }

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }

            private set
            {
                this.milliliters = value;
            }
        }

        public override decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                this.price = value * this.Milliliters;
            }
        }

        public UsageType Usage { get; set; }

        public override string ToString()
        {
            string baseString = base.Print();
            var builder = new StringBuilder();

            var haveQuantity = this.Milliliters > 0;
            var haveUsage = this.Usage != null;

            builder.AppendLine(baseString);
            builder.AppendLine(string.Format("  * Quantity: {0} ml", haveQuantity ? this.Milliliters.ToString() : ""));
            builder.AppendLine(string.Format("  * Usage: {0}", haveUsage ? this.Usage.ToString() : ""));

            return builder.ToString();
        }
    }
}
