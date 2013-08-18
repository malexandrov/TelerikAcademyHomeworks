using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Tomcat : Cat
    {
        // Hiding the sex field in Animal class with a constant - a Tomcat is always male
        private new const string sex = "male";

        // Constructor
        public Tomcat(string name, int age) : base(name,age)
        {    
        }

        new public string Sex { get { return sex; }}

        // Method
        public override void ProduceSound()
        {
            Console.WriteLine("Mhrn-Mhrn... MeoW I'm a TOMCAT named {0}!", this.name);
        }
    }
}
