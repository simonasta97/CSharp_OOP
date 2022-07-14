using Easter.Core.Contracts;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter
{
    public class Controller : IController
    {
        private List<Bunny> bunnies;
        private List<Egg> eggs;

        public Controller()
        {
            
        }
        
        public string AddBunny(string bunnyType, string bunnyName)
        {
            if (bunnyType== "HappyBunny")
            {
                bunnies.Add(new HappyBunny(bunnyName));
                return $"Successfully added {bunnyType} named {bunnyName}.";
            }
            else if (bunnyType == "SleepyBunny")
            {
                bunnies.Add(new SleepyBunny(bunnyName));
                return $"Successfully added {bunnyType} named {bunnyName}.";
            }
            else
            {
                return "Invalid bunny type.";
            }

        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            if (bunnies.Any(x => x.Name == bunnyName))
            {
                var currBunny = bunnies.FirstOrDefault(x => x.Name == bunnyName);
                currBunny.Dyes.Add(new Dye(power));
                return $"Successfully added dye with power {power} to bunny {bunnyName}!";
            }
            else
            {
                throw new InvalidOperationException("The bunny you want to add a dye to doesn't exist!");
            }
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            eggs.Add(new Egg(eggName, energyRequired));
            return $"Successfully added egg: {eggName}!";
        }

        public string ColorEgg(string eggName)
        {
            var sortBunny = bunnies.OrderByDescending(x => x.Energy).Where(x=>x.Energy>=50);
            if (sortBunny.Any() == false)
            {
                throw new InvalidOperationException("There is no bunny ready to start coloring!");
            }
            else
            {
                var currEgg = eggs.FirstOrDefault(x => x.Name == eggName);
                foreach (var bunny in sortBunny)
                {
                    currEgg.GetColored();
                    if (bunny.Energy <= 0)
                    {
                        bunnies.Remove(bunny);
                    }
                }
                var result = currEgg.IsDone();
                return $"Egg {eggName} is {result}.";
            }
            
        }

        public string Report()
        {
            var coloresEggs = eggs.Where(e => e.IsDone());
            var sb = new StringBuilder();
            sb.AppendLine($"{coloresEggs.Count()} eggs are done!");
            sb.AppendLine("Bunnies info:");
            foreach (var bunny in bunnies)
            {
                sb.AppendLine($"Name: {bunny.Name}");
                sb.AppendLine($"Energy: {bunny.Energy}");
                sb.AppendLine($"Dyes: {bunny.Dyes.Count()} not finished");
            }
            return sb.ToString().Trim();
        }
    }
}
