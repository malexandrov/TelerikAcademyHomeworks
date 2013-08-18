using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Kitten : Cat
    {
        // Hiding the sex field in Animal class with a constant - a Kitten is always female
        private new const string sex = "female";

        // Constructor
        public Kitten(string name, int age) : base(name,age)
        {    
        }

        new public string Sex { get { return sex; } }

        // Method
        public override void ProduceSound()
        {
            Console.WriteLine("Meow-Meow... MeoW I'm a KITTEH named {0}!", this.name);
        }
    }
}
