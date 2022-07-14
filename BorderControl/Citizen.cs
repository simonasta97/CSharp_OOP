using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; private set; }
        public Citizen(string name,int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
