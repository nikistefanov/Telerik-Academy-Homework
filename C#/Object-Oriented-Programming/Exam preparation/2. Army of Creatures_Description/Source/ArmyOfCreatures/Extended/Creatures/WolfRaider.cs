namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Extended.Specialties;

    public class WolfRaider : Creature
    {
        private const int InitialAttackPoints = 8;
        private const int InitialDefensePoints = 5;
        private const int InitialHealthPoints = 10;
        private const decimal InitialDamagePoints = 3.5m;

        public WolfRaider()
            : base (InitialAttackPoints, InitialDefensePoints, InitialHealthPoints, InitialDamagePoints)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}
