namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class AncientBehemoth : Creature
    {
        private const int InitialAttackPoints = 19;
        private const int InitialDefensePoints = 19;
        private const int InitialHealthPoints = 300;
        private const decimal InitialDamagePoints = 40;

        public AncientBehemoth()
            : base (InitialAttackPoints, InitialDefensePoints, InitialHealthPoints, InitialDamagePoints)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
        }
    }
}
