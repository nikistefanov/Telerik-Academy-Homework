namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    
    public class Toothpaste : Product, IToothpaste
    {
        private const int ProductIngredientMaxLengthValue = 13;
        private const int ProductIngredientMinLengthValue = 3;

        private List<string> ingredients;
        private decimal price;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, gender)
        {
            this.Price = price;
            this.ingredients = AddAndCheckIngredient(ingredients);
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ", this.ingredients);
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
                this.price = value;
            }
        }

        private List<string> AddAndCheckIngredient(IList<string> ingredientsInputed)
        {
            var checkedIngredients = new List<string>(ingredientsInputed);
            foreach (var ingredient in checkedIngredients)
            {
                Validator.CheckIfStringLengthIsValid(ingredient.ToString(), ProductIngredientMaxLengthValue, ProductIngredientMinLengthValue);
            }
            return checkedIngredients;
        }

        public override string ToString()
        {
            string baseString = base.Print();

            var haveIngredients = this.ingredients.Count > 0;
            var builder = new StringBuilder();
            builder.AppendLine(baseString);
            builder.AppendLine(string.Format("  * Ingredients: {0}", haveIngredients ? this.Ingredients : ""));

            return builder.ToString().Trim();
        }
    }
}
