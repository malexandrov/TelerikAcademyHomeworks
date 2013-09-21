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
             Student[] students = new Student[] {
                 new Student() { FirstName = "Petur", LastName = "Aleksandrov" , age = 18},
                 new Student() { FirstName = "Georgi", LastName = "Morov", age = 26 },
                 new Student() { FirstName = "Toshko", LastName = "ZTodorov", age = 24 },
                 new Student() { FirstName = "Roro", LastName = "Dorov", age = 32 },
                 new Student() { FirstName = "Nora", LastName = "Petrova", age = 25 }
             };

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
                 Console.WriteLine("{0} {1}, {2}", student.FirstName, student.LastName, student.age);
             }
         }
     }
}
