using Easter.Models.Eggs.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter
{
    public class Egg : IEgg
    {
        private string name;
        private int energyRequired; 
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value is null || value==" ")
                {
                    throw new ArgumentException("Egg name cannot be null or empty.");
                }
            }
        }

        public int EnergyRequired
        {
            get
            {
                return this.energyRequired;
            }
            set
            {
                if (value<0)
                {
                    this.energyRequired = 0;
                }
                else
                {
                    this.energyRequired = value;
                }
            }
        }

        public Egg(string name, int energyRequired)
        {
            this.Name = name;
            this.EnergyRequired = energyRequired;
        }
        public void GetColored()
        {
            EnergyRequired -= 10;
            if (EnergyRequired<0)
            {
                EnergyRequired = 0;
            }
        }

        public bool IsDone()
        {
            if (EnergyRequired==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
