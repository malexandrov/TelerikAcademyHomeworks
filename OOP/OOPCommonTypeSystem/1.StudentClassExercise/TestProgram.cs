using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentClassExercise
{

    class TestProgram
    {
        static void Main(string[] args)
        {
            Student pesho = new Student("Petur", "Petrov", "Petrov", "ul. Petrova Ulica N26", "pesho@gmail.com", 
                20612123, 884707043, 3, University.TelerikAcademy, Faculty.FMI, Speciality.Informatics);
            Console.WriteLine(pesho);
            Student peshoClone = pesho.Clone();
            Console.WriteLine(peshoClone);
            pesho.permAddress = "Nova ulica N16";
            peshoClone.permAddress = "PeshoClone ulica N16";
            Console.WriteLine(pesho);
            Console.WriteLine(peshoClone);

            Student pesho2 = new Student("Petur", "Petrov", "Petrov", "ul. Petrova Ulica N26", "pesho@gmail.com",
                106121243, 884707043, 3, University.TelerikAcademy, Faculty.FMI, Speciality.Informatics);

            //Console.WriteLine(pesho.GetHashCode());
            //Console.WriteLine(pesho2.GetHashCode());
            //Console.WriteLine(pesho.Equals(pesho2));

            Console.WriteLine(pesho.CompareTo(peshoClone));
            Console.WriteLine(pesho.CompareTo(pesho2));
        }
    }
}
