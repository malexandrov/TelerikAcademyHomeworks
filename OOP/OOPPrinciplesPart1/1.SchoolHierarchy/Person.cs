using System;
using System.Linq;

namespace _1.SchoolHierarchy
{
    public abstract class Person 
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        { 
            get { return this.name;  }
            set { this.name = value; } 
        }
    }
}
