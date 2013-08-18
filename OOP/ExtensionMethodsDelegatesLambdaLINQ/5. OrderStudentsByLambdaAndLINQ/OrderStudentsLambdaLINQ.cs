using System;
using System.Collections.Generic;
using System.Linq;


namespace _5.OrderStudentsByLambdaAndLINQ
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
    }

    class OrderStudentsLambdaLINQ
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            Student pesho = new Student() { FirstName = "Petur", LastName = "Aleksandrov", age = 18 };
            Student gosho = new Student() { FirstName = "Georgi", LastName = "Morov", age = 26 };
            Student tosho = new Student() { FirstName = "Toshko", LastName = "ZTodorov", age = 24 };
            Student roro = new Student() { FirstName = "Roro", LastName = "Dorov", age = 32 };
            Student nora = new Student() { FirstName = "Nora", LastName = "Petrova", age = 25 };

            students[0] = pesho;
            students[1] = gosho;
            students[2] = tosho;
            students[3] = roro;
            students[4] = nora;

            // Lambda
            var orderedStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            // LINQ
            StudentOrder(students);
        }

        static void StudentOrder(Student[] students)
        {
            var orderedStudents =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }                
        }
    }
}
