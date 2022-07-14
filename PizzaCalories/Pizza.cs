using System;
using System.Linq;
using System.Collections.Generic;
namespace PizzaCalories
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        


        public Pizza(string name, Dough dough, List<Topping> toppings)
        {
            Name = name;
            Dough = dough;
            Toppings = toppings;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public  List<Topping> Toppings
        {
            public get
            {
                return toppings;
            }
            set
            {
                if (value.Count > 10  || value.Count<0)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                toppings = value; // comment this
            }
        }

        public Dough Dough
        {
            get
            {
                return dough;
            }
            set
            {
                dough = value;
            }
        }


        public double TotalCalories { get => this.CalculateTotalCalories(); }
        private double CalculateTotalCalories()
        {
            return dough.CalculateCalories() + toppings.Sum(t => t.CalculateCalories());
        }

        public override string ToString()
        {
            return $"{Name} - {TotalCalories:F2} Calories.";
        }
    }
}
