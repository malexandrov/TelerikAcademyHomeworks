using System;
using System.Collections.Generic;
using System.Text;

namespace _1.SchoolHierarchy
{
    class Teacher : Person, ICommentable
    {
        private List<Discipline> setOfDisciplines = new List<Discipline>();
        public string comment { get; set; }

        // Constructor
        public Teacher(string name) : base(name)
        {
        }

        // Methods
        public void AddDiscipline(Discipline discipline)
        {
            setOfDisciplines.Add(discipline);
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public void ShowComment()
        {
            Console.WriteLine(comment);
        }
    }
}
