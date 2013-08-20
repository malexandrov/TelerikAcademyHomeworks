namespace TestSchool
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void SchoolConstructor_Test()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Assert.IsNotNull(school);
        }

        [TestMethod]
        public void AddCourse_Test()
        {
            List<Course> courses = new List<Course>();
            Course javascript = new Course("Javascript");
            School school = new School(courses);
            school.AddCourse(javascript);
            Assert.AreEqual(javascript.Name, school.Courses[0].Name);
        }

        [TestMethod]
        public void RemoveCourse_Test()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Course javascript = new Course("Javascript");
            school.AddCourse(javascript);
            school.RemoveCourse(javascript);
            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveNonExistingCourse_Test()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Course javascript = new Course("Javascript");
            school.RemoveCourse(javascript);
        }
    }
}