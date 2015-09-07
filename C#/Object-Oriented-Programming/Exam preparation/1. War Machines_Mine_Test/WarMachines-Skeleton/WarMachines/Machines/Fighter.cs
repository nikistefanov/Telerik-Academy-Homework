namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter, IMachine
    {
        private const int FighterInitialHealtPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints, FighterInitialHealtPoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            var builder = new StringBuilder();
            builder.Append(baseString);
            builder.Append(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));

            return builder.ToString();
        }
    }
}
