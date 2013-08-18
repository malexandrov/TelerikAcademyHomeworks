using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PersonClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Pesho", 36);
            Person person1 = new Person("Gosho", null);
            Person person2 = new Person("Tosho");
            Console.WriteLine(person);
            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
