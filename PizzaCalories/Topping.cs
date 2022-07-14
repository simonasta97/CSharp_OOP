using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Topping
    {
        private double weight;
        private string name;

        public string Name
        {
            get => this.name;
            set
            {
                if (value.ToLower()!= "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.name = value;
            }
        }
        public double Weight 
        {
            get => this.weight;
            set
            {
                if (value<1 || value >50)
                {
                    throw new ArgumentException($"{this.Name} weight should be in the range[1..50].");
                }
                this.weight = value;
            }
        }


        public Topping(string name,double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public double CalculateCalories()
        {
            double typeModifier = 0;
            if (Name.ToLower() == "meat")
            {
                typeModifier = 1.2;
            }
            else if (Name.ToLower() == "veggies")
            {
                typeModifier = 0.8;
            }
            else if (Name.ToLower() == "cheese")
            {
                typeModifier = 1.1;
            }
            else if (Name.ToLower() == "sauce")
            {
                typeModifier = 0.9;
            }

            return 2 * weight * typeModifier;
        }
    }
}
