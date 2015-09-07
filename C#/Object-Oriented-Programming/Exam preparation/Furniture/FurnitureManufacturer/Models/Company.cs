namespace FurnitureManufacturer.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentNullException("Name cannot be less than 5 symbols!");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            protected set
            {
                if (value == null || value.Length != 10)
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols!");
                }

                if (!this.ContainsOnlyDigit(value))
                {
                    throw new ArgumentException("Registration number must contains only digits!");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
                // or this!
                //return new List<IFurniture>(this.furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());

            // or another way
            /*foreach (var furnitureInCollection in this.furnitures)
            {
                if (string.Compare(furnitureInCollection.Model, model, true) == 0)
                {
                    return furnitureInCollection;
                }
            }

            return null;*/
        }

        public string Catalog()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("{0} - {1} - {2} {3}",
                    this.Name,
                    this.RegistrationNumber,
                    this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                    this.Furnitures.Count != 1 ? "furnitures" : "furniture"));
            foreach (var furniture in this.furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model))
            {
                builder.AppendLine(furniture.ToString());
            }

            return builder.ToString().TrimEnd();
        }

        private bool ContainsOnlyDigit(string str)
        {
            foreach (var ch in str)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
                //if (ch < '0' || ch > '9')
                //{
                //    return false;
                //}
            }

            return true;
        }
    }
}
