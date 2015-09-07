namespace TradeAndTravel
{
    using System.Collections.Generic;

    public class Weapon : Item
    {
        private const int GeneralValue = 10;

        public Weapon(string name, Location location = null)
            : base(name, Weapon.GeneralValue, ItemType.Weapon, location)
        {
        }
    }
}
