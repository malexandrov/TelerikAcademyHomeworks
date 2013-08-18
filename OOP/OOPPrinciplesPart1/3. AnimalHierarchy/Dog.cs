using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Dog: Animal
    {
         // Constructor
        public Dog(string name, int age, string sex) : base(name,age,sex)
        {    
        }
        // Method 
        public override void ProduceSound()
        {
            Console.WriteLine("Bow-WoW I'm a DOG named {0}!", this.name);
        }
    }
}
