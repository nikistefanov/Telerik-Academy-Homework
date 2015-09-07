namespace ChefClass.Ingredients
{
    public abstract class Vegetable
    {
        public Vegetable()
        {
            this.IsPeeled = false;
            this.IsCut = false;
            this.IsCooked = false;
        }

        public bool IsPeeled { get; set; }
        public bool IsCut { get; set; }

        public bool IsCooked { get; set; }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Peel()
        {
            this.IsPeeled = true;
        }

        public void Cook()
        {
            this.IsCooked = true;
        }

        public override string ToString()
        {
            string name = this.GetType().Name;
            string peeled = this.IsPeeled ? "peeled" : "not peeled";
            string cut = this.IsCut ? "cut" : "not cut";

            return string.Format("{0} is {1} and is {2}", name, peeled, cut);
        }
    }
}
