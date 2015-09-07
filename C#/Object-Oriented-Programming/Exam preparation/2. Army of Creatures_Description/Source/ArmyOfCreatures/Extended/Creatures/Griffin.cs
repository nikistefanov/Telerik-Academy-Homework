namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin : Creature
    {
        private const int InitialAttackPoints = 8;
        private const int InitialDefensePoints = 8;
        private const int InitialHealthPoints = 25;
        private const decimal InitialDamagePoints = 4.5m;

        public Griffin()
            : base (InitialAttackPoints, InitialDefensePoints, InitialHealthPoints, InitialDamagePoints)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
            this.AddSpecialty(new AddDefenseWhenSkip(3));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
