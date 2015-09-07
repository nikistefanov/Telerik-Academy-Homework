﻿namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank, IMachine
    {
        private const int TankHealthPoints = 100;
        private const int AttackPointsChange = 40;
        private const int DefensePointsChange = 30;
        
        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, TankHealthPoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode)
            {
                this.AttackPoints -= AttackPointsChange;
                this.DefensePoints += DefensePointsChange;
            }
            else
            {
                this.AttackPoints += AttackPointsChange;
                this.DefensePoints -= DefensePointsChange;
            }
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            var builder = new StringBuilder();
            builder.Append(baseString);
            builder.Append(string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF"));

            return builder.ToString();
        }
    }
}
