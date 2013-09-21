using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.StudentNames
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class LINQMethodProgram
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            Student pesho = new Student() { FirstName = "Petur", LastName = "Aleksandrov" };
            Student gosho = new Student() { FirstName = "Georgi", LastName = "Morov" };
            Student tosho = new Student() { FirstName = "Toshko", LastName = "ZTodorov" };
            Student roro = new Student() { FirstName = "Roro", LastName = "Dorov" };
            Student nora = new Student() { FirstName = "Nora", LastName = "Petrova" };

            students[0] = pesho;
            students[1] = gosho;
            students[2] = tosho;
            students[3] = roro;
            students[4] = nora;

            FirstNameFirst(students);
        }

        static void FirstNameFirst(Student[] students)
        {
            var queryStudentNames =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var student in queryStudentNames)
            {
                //Console.WriteLine(name);
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
