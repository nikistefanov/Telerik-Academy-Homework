namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Common;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Validator.CheckIfStringIsNullOrEmpty(value, "Pilot name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.CheckIfNull(machine, "Machine cannot be null!");
            this.machines.Add(machine);
        }

        public string Report()
        {
            var sortedMachines = this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);

            var builder = new StringBuilder();

            var haveMachines = this.machines.Count > 0 ? this.machines.Count.ToString() : "no";

            var pluralMachines = this.machines.Count == 1 ? "machine" : "machines";

            builder.AppendLine(string.Format("{0} - {1} {2}", this.Name, haveMachines, pluralMachines));

            foreach (var machine in sortedMachines)
            {
                builder.AppendLine(machine.ToString());
            }

            return builder.ToString().Trim();
        }
    }
}
