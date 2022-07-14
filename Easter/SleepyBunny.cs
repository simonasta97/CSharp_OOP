using Easter.Models.Bunnies.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter
{
    public class SleepyBunny : Bunny
    {

        private const int initialEnergy = 50;
        private string name;

        public string Name { get; set; }
        public SleepyBunny(string name) : base(name)
        {
            
        }

        public override void Work()
        {
            Energy -= 15;
            if (Energy < 0)
            {
                this.Energy = 0;
            }
        }

        public override int Energy => initialEnergy;

    }
}
