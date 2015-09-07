namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    public class CyclopsKing : Creature
    {
        private const int InitialAttackPoints = 17;
        private const int InitialDefensePoints = 13;
        private const int InitialHealthPoints = 70;
        private const decimal InitialDamagePoints = 18;

        public CyclopsKing()
            : base (InitialAttackPoints, InitialDefensePoints, InitialHealthPoints, InitialDamagePoints)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
