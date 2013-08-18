using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    abstract class Cat : Animal
    {
        // Constructor
        public Cat(string name, int age) : base(name,age)
        {    
        }
    }
}
