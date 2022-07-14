using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pizzaName = Console.ReadLine().Split()[1];
            string[] doughInfo = Console.ReadLine().Split();
            string flourType = doughInfo[1];
            string bakingTechnique = doughInfo[2];
            double weight = double.Parse(doughInfo[3]);

            List<Topping> toppings = new List<Topping>();


            while (true)
            {
                string[] toppingInfo = Console.ReadLine().Split();
                if (toppingInfo[0] == "END")
                {
                    break;
                }
                string toppingType = toppingInfo[1];
                double toppingWeight = double.Parse(toppingInfo[2]);

                try
                {
                    Topping topping = new Topping(toppingType, toppingWeight);
                    toppings.Add(topping);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    return;
                }
            }
            try
            {
                Dough dough = new Dough(flourType, bakingTechnique, weight);
                Pizza pizza = new Pizza(pizzaName, dough, toppings);
                Console.WriteLine(pizza.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }
        }
    }
}
