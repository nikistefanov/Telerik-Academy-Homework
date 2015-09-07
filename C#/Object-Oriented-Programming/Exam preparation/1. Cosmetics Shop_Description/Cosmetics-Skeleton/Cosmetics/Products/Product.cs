namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Product : IProduct
    {
        private const int ProductNameMinLengthValue = 3;
        private const int ProductNameMaxLengthValue = 10;
        private const int ProductBrandMinLengthValue = 2;
        private const int ProductBrandMaxLengthValue = 10;

        private string name;
        private string brand;
        private decimal price;

        protected Product(string name, string brand, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                // I couldn't find a way to add params to add params trougth GlobalErrorMessages :(
                Validator.CheckIfStringLengthIsValid(value, ProductNameMaxLengthValue, ProductNameMinLengthValue, string.Format("Product name must be between {0} and {1} symbols long!", ProductNameMinLengthValue, ProductNameMaxLengthValue));
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            private set
            {
                // I couldn't find a way to add params to add params trougth GlobalErrorMessages :(
                Validator.CheckIfStringLengthIsValid(value, ProductBrandMaxLengthValue, ProductBrandMinLengthValue, string.Format("Product brand must be between {0} and {1} symbols long!", ProductBrandMinLengthValue, ProductBrandMaxLengthValue));
                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to $0.00!");
                }
                this.price = value;
            }
        }

        public GenderType Gender { get; set; }

        public string Print()
        {
            var builder = new StringBuilder();

            builder.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            builder.AppendLine(string.Format("  * Price: ${0}", this.Price));
            builder.AppendLine(string.Format("  * For gender: {0}", this.Gender));

            return builder.ToString().Trim();
        }
    }
}
