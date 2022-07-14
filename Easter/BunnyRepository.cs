using Easter.Models.Bunnies.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easter.Repositories.Contracts;


namespace Easter
{
    public class BunnyRepository : IRepository<IBunny>
    {
        private HashSet<IBunny> models;

        public IReadOnlyCollection<IBunny> Models { get { return this.models; } set { } }
   

        public void Add(IBunny Bunny)
        {
            models.Add((Bunny)Bunny);
        }
        public bool Remove(IBunny Bunny)
        {
            if (models.Contains((Bunny)Bunny))
            {
                models.Remove((Bunny)Bunny);
                return true;
            }
            else
            {
                return false;
            }
        }
        public IBunny FindByName(string name)
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
