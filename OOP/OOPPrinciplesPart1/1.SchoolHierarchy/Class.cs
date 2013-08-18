using System;
using System.Collections.Generic;

namespace _1.SchoolHierarchy
{
    class Class : ICommentable
    {
        private List<Student> setOfstudents = new List<Student>();
        private List<Teacher> setOfTeachers = new List<Teacher>();
        private string textIdentifier;

        // Constructor
        public Class(string textIdentifier)
        {
            this.textIdentifier = textIdentifier;
        }

        // Properties
        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                this.textIdentifier = value;
            }
        }

        public List<Student> StudentsList
        {
            get
            {
                return this.setOfstudents;
            }
        }

        public List<Teacher> TeachersList
        {
            get
            {
                return this.setOfTeachers;
            }
        }

        //Methods
        public void AddStudent(Student student)
        {
            this.setOfstudents.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            this.setOfTeachers.Add(teacher);
        }

        public string Comment
        {
            get
            {
                return this.Comment;
            }
            set
            {
                this.Comment = value;
            }
        }

        public void ShowComment()
        {
            Console.WriteLine(this.Comment);
        }
    }
}
