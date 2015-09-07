namespace TradeAndTravel
{
    public class Iron : Item
    {
        private const int GeneralValue = 3;

        public Iron(string name, Location location = null)
            : base(name, Iron.GeneralValue, ItemType.Iron, location)
        {
        }

    }
}
