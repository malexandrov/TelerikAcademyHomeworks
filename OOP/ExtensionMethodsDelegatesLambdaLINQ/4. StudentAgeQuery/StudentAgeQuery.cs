using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.StudentAgeQuery
{
 
     class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
    }

     class StudentAgeQuery
     {
         static void Main(string[] args)
         {
             Student[] students = new Student[5];
             Student pesho = new Student() { FirstName = "Petur", LastName = "Aleksandrov" , age = 18};
             Student gosho = new Student() { FirstName = "Georgi", LastName = "Morov", age = 26 };
             Student tosho = new Student() { FirstName = "Toshko", LastName = "ZTodorov", age = 24 };
             Student roro = new Student() { FirstName = "Roro", LastName = "Dorov", age = 32 };
             Student nora = new Student() { FirstName = "Nora", LastName = "Petrova", age = 25 };

             students[0] = pesho;
             students[1] = gosho;
             students[2] = tosho;
             students[3] = roro;
             students[4] = nora;

             StudentOFCertainAge(students);
         }

         static void StudentOFCertainAge(Student[] students)
         {
             var queryStudentNames =
                 from student in students
                 where (student.age >= 18) && (student.age <= 25)
                 select student;

             foreach (var student in queryStudentNames)
             {
                 //Console.WriteLine(name);
                 Console.WriteLine("{0} {1}, {2}", student.FirstName, student.LastName, student.age);
             }
         }
     }
}
