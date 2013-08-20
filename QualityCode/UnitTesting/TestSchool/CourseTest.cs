namespace TestSchool
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseConstructor_TestName()
        {
            string name = "KPK";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, "KPK");
        }

        [TestMethod]
        public void CourseConstructor_TestListStudents()
        {
            string name = "KPK";
            Student gosho = new Student("Gosho Goshev", 12345);
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            course.AddStudent(gosho);
            Assert.IsTrue(course.Students.Contains(gosho));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Name_TestNullValue()
        {
            string name = null;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Name_TestEmptyString()
        {
            string name = string.Empty;
            Course newCourse = new Course(name);
        }

        [TestMethod]
        public void AddStudent_TestOneStudent()
        {
            string name = "KPK";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student gosho = new Student("Gosho Goshev", 12345);
            course.AddStudent(gosho);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        public void AddStudent_TestTwoStudents()
        {
            string name = "KPK";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student gosho = new Student("Gosho Goshev", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.AddStudent(gosho);
            course.AddStudent(petar);
            Assert.IsTrue(course.Students.Count == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddStudent_TestSameStudent2Times()
        {
            string name = "KPK";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student gosho = new Student("Gosho Goshev", 12345);
            course.AddStudent(gosho);
            course.AddStudent(gosho);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudent_TestMoreThanMaximumStudents()
        {
            string name = "KPK";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            for (int i = 10000; i < 10031; i++)
            {
                course.AddStudent(new Student("Gosho Goshev", i));
            }
        }

        [TestMethod]
        public void RemoveStudent_Test()
        {
            string name = "KPK";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student gosho = new Student("Gosho Goshev", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            course.AddStudent(gosho);
            course.AddStudent(petar);
            course.RemoveStudent(petar);
            Assert.IsTrue(course.Students.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingStudent_Test()
        {
            string name = "KPK";
            IList<Student> students = new List<Student>();
            Course course = new Course(name, students);
            Student gosho = new Student("Gosho Goshev", 12345);
            course.RemoveStudent(gosho);
        }

        [TestMethod]
        public void ToString_TestOneStudent()
        {
            string name = "KPK";
            Student gosho = new Student("Gosho Goshev", 12345);
            IList<Student> students = new List<Student>();
            Course KPK = new Course(name, students);
            KPK.AddStudent(gosho);
            string expected = "Course name KPK; Student Gosho Goshev, number 12345.";
            string actual;
            actual = KPK.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_Test2Students()
        {
            string name = "KPK";
            Student gosho = new Student("Gosho Goshev", 12345);
            Student petar = new Student("Petar Marinov", 23445);
            IList<Student> students = new List<Student>();
            Course KPK = new Course(name, students);
            KPK.AddStudent(gosho);
            KPK.AddStudent(petar);
            string expected = "Course name KPK; Student Gosho Goshev, number 12345.Student Petar Marinov, number 23445.";
            string actual;
            actual = KPK.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}