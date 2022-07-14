using Easter.Models.Eggs.Contracts;
using Easter.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter
{
    public class EggRepository : IRepository<IEgg>
    {
        private HashSet<IEgg> models;

        public IReadOnlyCollection<IEgg> Models { get { return this.models; } set { } }

        public void Add(IEgg Egg)
        {
            models.Add((Egg)Egg);
        }
        public bool Remove(IEgg Egg)
        {
            if (models.Contains((Egg)Egg))
            {
                models.Remove((Egg)Egg);
                return true;
            }
            else
            {
                return false;
            }
        }
        public IEgg FindByName(string name)
        {
            if (models.Any(n => n.Name == name))
            {
                return models.FirstOrDefault(n => n.Name == name);
            }
            else
            {
                return null;
            }
        }
    }
}
