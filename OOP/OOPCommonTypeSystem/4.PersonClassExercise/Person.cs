using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersonClassExercise
{
    class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            string result = "Name: " + this.name + "Age: " + ( (this.age != null) ? this.age.ToString() : "age not specified" );
            return result;
        }
    }
}
