namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;

    public class Goblin : Creature
    {
        private const int InitialAttackPoints = 4;
        private const int InitialDefensePoints = 2;
        private const int InitialHealthPoints = 5;
        private const decimal InitialDamagePoints = 1.5m;

        public Goblin()
            : base (InitialAttackPoints, InitialDefensePoints, InitialHealthPoints, InitialDamagePoints)
        {
        }

    }
}
