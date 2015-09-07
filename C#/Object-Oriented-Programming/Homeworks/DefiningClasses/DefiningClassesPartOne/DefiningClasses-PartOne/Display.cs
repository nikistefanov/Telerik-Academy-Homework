using System;

namespace MobilePhones
{
    // display characteristics (size and number of colors)
    public class Display
    {
        private double sizeInInches;
        private uint colors;

        // Problem 2. Constructors
        public Display()
        {
        }

        public Display(double size)
        {
        }

        public Display(double size, uint colors)
        {
            this.sizeInInches = size;
            this.colors = colors;
        }


        public double Size
        {
            get
            {
                return this.sizeInInches;
            }
            private set
            {
                if (sizeInInches < 3.5 || sizeInInches > 8.0)
                {
                    throw new ArgumentException("We have display only between 3.5 inches and 8.0 inches.");
                }
                this.sizeInInches = value;
            }
        }

        public uint Colors
        {
            get
            {
                return this.colors;
            }
            private set
            {
                if (colors < 256 && colors > 2000000)
                {
                    throw new ArgumentException("Colors must be between 256 and 2 000 000!");
                }
                this.colors = value;
            }
        }

        // Problem 4. ToString
        public override string ToString()
        {
            string star = new string('*', 40);
            return String.Format("\n{0}\nSize in inches: {1}\nColors: {2}\n{0}",star ,
                this.Size, this.Colors, star);
        }
    }
}
