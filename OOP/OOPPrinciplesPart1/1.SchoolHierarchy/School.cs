using System;
using System.Collections.Generic;
using System.Text;

namespace _1.SchoolHierarchy
{
    class School
    {
        public string schoolName;
        private List<Class> classes = new List<Class>();

        //Constructor
        public School(string schoolName)
        {
            this.schoolName = schoolName;
        }

        // Methods
        public void AddClass(Class schoolClass)
        {
            this.classes.Add(schoolClass);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("School: {0}", this.schoolName);

            foreach (Class schoolClass in classes)
            {
                sb.AppendFormat("\r\n{0}", schoolClass);
            }
            return sb.ToString();
        }
        
    }
}
