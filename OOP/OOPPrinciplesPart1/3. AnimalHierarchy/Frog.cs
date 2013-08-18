using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Frog : Animal
    {
        // Constructor
        public Frog(string name, int age, string sex) : base(name,age,sex)
        {    
        }

        // Method
        public override void ProduceSound()
        {
            Console.WriteLine("Rrribbid-Rrribbid I'm a FROG named {0}!", this.name);
        }
    }
}
