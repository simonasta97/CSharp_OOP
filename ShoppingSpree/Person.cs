using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<string> bag;

        public Person(string name,decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<string>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public List<string> Bag
        {
            get { return this.bag; }
        }

        public void BuyProduct(Product product)
        {
            if (product.Cost > this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");

                this.Money -= product.Cost;
                this.bag.Add(product.Name);
            }
        }

        public override string ToString()
        {
            string person = $"{this.Name} - ";

            if (this.bag.Count == 0)
            {
                person += "Nothing bought";
            }
            else
            {
                person += string.Join(", ", this.bag);
            }

            return person;
        }

    }
}
