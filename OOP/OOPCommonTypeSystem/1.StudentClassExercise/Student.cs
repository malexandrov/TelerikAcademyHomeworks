using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentClassExercise
{
    [Serializable]
    class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        public string permAddress { get; set; }
        private string email { get; set; }
        private int studentSSN;
        private int mobilePhone { get; set; }
        private int course { get; set; }

        private University university;
        private Faculty faculty;
        private Speciality speciality;

        // Constructor
        public Student(string firstName, string middleName, string lastName, string address, string email,
            int ssn, int mobilePhone, int course, University university, Faculty faculty, Speciality speciality)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.permAddress = address;
            this.email = email;
            this.studentSSN = ssn;
            this.mobilePhone = mobilePhone;
            this.course = course;
            this.university = university;
            this.faculty = faculty;
            this.speciality = speciality;
        }

        // Overriden methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.firstName + " " + this.middleName + " " + this.lastName);
            sb.AppendLine(this.permAddress);
            sb.AppendLine(this.email + " " + this.mobilePhone);
            sb.AppendLine(this.studentSSN.ToString());
            sb.AppendLine(this.course.ToString());
            sb.AppendFormat("{0} {1} {2}", this.university, this.faculty, this.speciality);
            sb.AppendLine();
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if ((Object)student == null)
            {
                return false;
            }
            if (! Object.Equals(this.firstName, student.firstName))
            {
                return false;
            }
            if (this.studentSSN != student.studentSSN)
	        {
                return false;
	        }
            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return firstName.GetHashCode() ^ studentSSN.GetHashCode();
        }

        Object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                Student original = this;
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, original);
                stream.Position = 0;
                return (Student)formatter.Deserialize(stream);
            }
        }

        public int CompareTo(Student other)
        {
            if (this.firstName != other.firstName)
            {
                return this.firstName.CompareTo(other.firstName);
            }
            if (this.middleName != other.middleName)
            {
                return this.middleName.CompareTo(other.middleName);
            }
            if (this.lastName != other.lastName)
            {
                return this.lastName.CompareTo(other.lastName);
            }
            if (this.studentSSN != other.studentSSN)
            {
                return this.studentSSN.CompareTo(other.studentSSN);
            }
            return 0;
        }
    }
}
