using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (value.ToLower() != "wholegrain"&& value.ToLower() != "white")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }
        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public Dough(string flourType,string bakingTechnique,double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public double CalculateCalories()
        {
            double bakingModifier = 0;
            double flourModifier = 0;
            if (FlourType.ToLower() == "white")
            {
                flourModifier = 1.5;
            }
            else if (FlourType.ToLower() == "wholegrain")
            {
                flourModifier = 1.0;
            }

            if (this.BakingTechnique.ToLower() == "crispy")
            {
                bakingModifier = 0.9;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                bakingModifier = 1.1;
            }
            else if (this.BakingTechnique.ToLower() == "homemade")
            {
                bakingModifier = 1.0;
            }

            return 2 * weight * bakingModifier * flourModifier;
        }
    }
}
