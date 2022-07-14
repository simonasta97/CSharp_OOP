using Easter.Models.Dyes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter
{
    public class Dye : IDye
    {
        private int power;
        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                if (value<0)
                {
                    this.power = 0;
                }
                else
                {
                    this.power = value;
                }
            }
        }

        public Dye(int power)
        {
            this.Power = power;
        }
        public bool IsFinished()
        {
            if (this.Power ==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Use()
        {
            Power -= 10;
            if (Power<0)
            {
                this.Power = 0;
            }
        }
    }
}
