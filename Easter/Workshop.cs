using Easter.Models.Bunnies.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter
{
    public class Workshop : IWorkshop
    {
        public void Color(IEgg egg, IBunny bunny)
        {
            while (egg.IsDone()&& bunny.Energy>0&&bunny.Dyes.Count>0)
            {
                if (bunny.Energy > egg.EnergyRequired && bunny.Dyes.Count > 0)
                {
                    egg.GetColored();
                }
            }
            
        }
    }
}
