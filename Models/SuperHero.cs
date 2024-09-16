using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_001.Models
{
    internal class SuperHero
    {
        public string Name { get; set; }
        public string HeroName { get; set; }

        public override string ToString()
        {
            return $"{Name} : {HeroName}";
        }

        public SuperHero()
        {
           //Console.WriteLine("Super hero class is created");
        }

        public SuperHero(string name, string heroName)
        {
            HeroName = heroName;
            Name = name;
        }

      
    }
}
