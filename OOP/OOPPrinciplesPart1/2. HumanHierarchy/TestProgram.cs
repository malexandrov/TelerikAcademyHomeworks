using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.HumanHierarchy
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            // Sort a list of students
            List<Student> listOfStudents = new List<Student>()
            {
                new Student("Petur", "Petrov", 4.45f),
                new Student("Georgi", "Georgiev", 5.45f),
                new Student("Tihomir", "Todorov", 6.00f),
                new Student("Desislava", "Petrova", 4.33f),
                new Student("Teodora", "Teodorova", 2.00f),
                new Student("Mira", "Lalalalova", 3.14f),
                new Student("Petur", "Baiov", 2.67f),
                new Student("Lubomir", "Bainov", 5.01f),
                new Student("Martin", "Babaiov", 5.55f),
            };

            var orderedStudents = listOfStudents.OrderBy(x => x.Grade);
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Grade);
            }

            Console.WriteLine();

            // Sort a list of workers
            List<Worker> listOfWorkers = new List<Worker>()
            {
                new Worker("Kinka", "Petrova", 250f, 8),
                new Worker("Penka", "Georgieva", 500f, 8),
                new Worker("Nora", "Todorova", 750f, 12),
                new Worker("Dora", "Petrova", 450f, 7),
                new Worker("Lora", "Teodorova", 250f, 3),
                new Worker("Dushka", "Tralala", 250f, 10),
                new Worker("Baino", "Bainov", 250f, 9),
                new Worker("Lubomira", "Bainova", 250f, 8),
                new Worker("Martin", "Lalalalov", 150f, 5),
            };

            var orderedWorkers = listOfWorkers.OrderByDescending(x => x.MoneyPerHour());
            foreach (Worker worker in orderedWorkers)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker.MoneyPerHour());
            }
            Console.WriteLine();

            // Sort the merged lists

            var mergedLists = new List<Human>(listOfStudents);
            mergedLists.AddRange(listOfWorkers);

            var orderedHuman = mergedLists.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var human in orderedHuman)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}
