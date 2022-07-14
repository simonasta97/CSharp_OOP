using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter
{
    public abstract class Bunny :  IBunny
    {
        private string name;
        private int energy;
        private Bunny(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == " ")
                {
                    throw new ArgumentException("Bunny name cannot be null or empty.");
                }
                this.name = value;
            }
        }


        public virtual int Energy
        {
            get
            {
                return this.energy;
            }
            set
            {
                if (value<0)
                {
                    this.energy = 0;
                }
                else
                {
                    this.energy = value;
                }
            }
        }

        public ICollection<IDye> Dyes { get; set; }

        public Bunny(string name)
        {
            this.Name = name;
        }

        public void AddDye(IDye dye)
        {
            Dyes.Add(dye);
        }

        public abstract void Work();
    }
}
