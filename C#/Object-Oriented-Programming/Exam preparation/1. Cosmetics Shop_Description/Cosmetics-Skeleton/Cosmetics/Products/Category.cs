namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private const int CategoryNameMinLengthvalue = 2;
        private const int CategoryNameMaxLengthvalue = 15;

        private string name;
        private ICollection<IProduct> cosmetics;

        public Category(string name)
        {
            this.Name = name;
            this.cosmetics = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringLengthIsValid(value, 15, 2, string.Format("{0} name must be between {1} and {2} symbols long!", this.GetType().Name, CategoryNameMinLengthvalue, CategoryNameMaxLengthvalue));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.cosmetics.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            this.cosmetics.Remove(cosmetics);
        }

        public string Print()
        {
            var builder = new StringBuilder();

            var sortedCosmetics = this.cosmetics.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);
            var haveProducts = this.cosmetics.Count > 0 ? this.cosmetics.Count.ToString() : "0";
            var pluralProducts = this.cosmetics.Count == 1 ? "product" : "products";

            builder.AppendLine(string.Format("{0} category - {1} {2} in total", this.Name, haveProducts, pluralProducts));

            foreach (var product in sortedCosmetics)
            {
                builder.AppendLine(product.ToString());
            }

            return builder.ToString().Trim();
        }
    }
}
