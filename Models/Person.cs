using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_001.Models
{
    public class Person
    {

      //  public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} : {Age}";
        }

    }
}
