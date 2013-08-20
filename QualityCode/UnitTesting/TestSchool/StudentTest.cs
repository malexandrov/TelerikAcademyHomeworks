namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentConstructor_TestName()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
            Assert.AreEqual(student.Name, "Gosho Peshov");
        }

        [TestMethod]
        public void StudentConstructor_TestUniqueNumber()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
            Assert.AreEqual(student.UniqueNumber, 12345);
        }

        [TestMethod]
        public void UniqueNumber_TestStartValue()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = 10000;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void UniqueNumber_TestEndValue()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = 99999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void ToString_Test()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
            string expected = "Student Gosho Peshov, number 12345.";
            string actual;
            actual = student.ToString();
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class StudentExceptionsTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Name_TestNullValue()
        {
            string name = null;
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Name_TestEmptyString()
        {
            string name = string.Empty;
            int uniqueNumber = 12345;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumber_TestStartValueMinusOne()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = 9999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void UniqueNumber_TestStartValue()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = 10000;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void UniqueNumber_TestEndValue()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = 99999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        public void UniqueNumber_TestEndValuePlusOne()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = 99999;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 100000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumber_TestNegativeValue()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = -55555;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumber_TestZero()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = 0;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueNumber_TestIntMaxValue()
        {
            string name = "Gosho Peshov";
            int uniqueNumber = int.MaxValue;
            Student student = new Student(name, uniqueNumber);
            Assert.IsTrue(uniqueNumber >= 10000 && uniqueNumber <= 99999);
        }
    }
}