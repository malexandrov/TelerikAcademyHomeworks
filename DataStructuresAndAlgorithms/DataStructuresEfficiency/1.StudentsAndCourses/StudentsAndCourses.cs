namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class StudentsAndCourses
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Student>> courses = new SortedDictionary<string, List<Student>>();
            StreamReader reader = new StreamReader("..\\..\\students.txt");
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] tokens = line.Split('|');
                    string firstName = tokens[0].Trim();
                    string lastName = tokens[1].Trim();
                    string course = tokens[2].Trim();

                    List<Student> students;
                    if (!courses.TryGetValue(course, out students))
                    {
                        students = new List<Student>();
                        courses.Add(course,students);
                    }
                    Student student = new Student(firstName, lastName);
                    students.Add(student);
                }
            }

            foreach (var course in courses)
            {
                List<Student> students = course.Value;
                students.Sort();

                string resultString = course.Key + ": " + string.Join(", ", students);
                Console.WriteLine(resultString);
            }
        }
    } 
}
