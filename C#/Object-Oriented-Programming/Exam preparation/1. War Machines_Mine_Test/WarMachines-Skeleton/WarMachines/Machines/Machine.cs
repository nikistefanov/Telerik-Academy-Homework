namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Common;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        protected Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.CheckIfNullOrEmpty(value, "Machine name cannot be null or empty!");
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                Validator.CheckIfNull(value, "Pilot cannot be null!");
                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            Validator.CheckIfNullOrEmpty(target);
            this.targets.Add(target);
        }

        public override string ToString()
        {
            var targetsAsString = this.targets.Count > 0 ? string.Join(", ", this.targets) : "None";
            var builder = new StringBuilder();


            builder.AppendLine(string.Format("- {0}", this.Name));
            builder.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            builder.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            builder.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            builder.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            builder.AppendLine(string.Format(" *Targets: {0}", targetsAsString));

            return builder.ToString();
        }
    }
}
