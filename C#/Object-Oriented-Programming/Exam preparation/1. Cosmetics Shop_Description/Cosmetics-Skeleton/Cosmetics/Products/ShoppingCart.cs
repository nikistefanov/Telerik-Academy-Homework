namespace Cosmetics.Products
{
    using System.Linq;
    using System.Collections.Generic;

    using Cosmetics.Contracts;

    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        public ICollection<IProduct> Products
        {
            get
            {
                return new List<IProduct>(this.products);
            }
        }

        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.products.Any(p => p == product);
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in this.products)
            {
                //if (product.Name == "Shampoo")
                //{
                //}
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
