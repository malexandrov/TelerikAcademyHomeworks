using System;

namespace _1.SchoolHierarchy
{
    class Discipline : ICommentable
    {
        private string name;
        private int lectures;
        private int exercises;
        public string comment { get; set; }

        // Constructor

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.name = name;
            this.lectures = numberOfLectures;
            this.exercises = numberOfExercises;
        }

        // Properties
        public string Name { get; private set; }
        public int Lectures { get; private set; }
        public int Exercises { get; private set; }

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
            Console.WriteLine(this.comment);
        }
    }
}
