namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, ITable
    {

        public Table(string model, MaterialType materialType, decimal price, decimal height, decimal length, decimal width)
        {
            this.Model = model;
            this.MaterialType = materialType;
            this.Price = price;
            this.Height = height;
            this.Length = length;
            this.Width = width;
        }

        public decimal Length { get; private set; }

        public decimal Width { get; private set; }

        public decimal Area
        {
            get
            {
                return this.Length * this.Width;
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.Length, this.Width, this.Area);
        }
    }
}
