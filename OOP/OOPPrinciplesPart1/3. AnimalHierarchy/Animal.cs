using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.AnimalHierarchy
{
    abstract class Animal : ISound
    {
        protected string name;
        protected int age;
        protected string sex;

        // Constructors
        public Animal(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Properties
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public string Sex { get { return this.sex; } set { this.sex = value; } }

        // Methods
        public abstract void ProduceSound();
    }
}
