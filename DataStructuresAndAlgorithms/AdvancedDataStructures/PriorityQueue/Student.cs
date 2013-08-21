namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class Student : IComparable<Student>
    {
        public string Name;
        public long Number; // smaller values are higher priority

        public Student(string name, long number)
        {
            this.Name = name;
            this.Number = number;
        }

        public override string ToString()
        {
            return "(" + Name + ", " + Number.ToString() + ")";
        }

        public int CompareTo(Student other)
        {
            if (this.Number < other.Number) return -1;
            else if (this.Number > other.Number) return 1;
            else return 0;
        }
    }
}
