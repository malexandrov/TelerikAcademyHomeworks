using System;
using System.Linq;

namespace _2.HumanHierarchy
{
    class Student : Human
    {
        private float grade;

        public Student(string firstName, string lastName, float grade = 2)
            : base(firstName, lastName)
        {
            this.grade = grade;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public float Grade { get { return this.grade; } set { this.grade = value; } }
    }
}
