using System;
using System.Linq;

namespace _1.SchoolHierarchy
{
    class Student : Person, ICommentable
    {
        private uint uniqueClassNum;
        public string comment { get; set; }

        // Constructor
        public Student(string name, uint uniqueClassNum) : base(name)
        {
            this.uniqueClassNum = uniqueClassNum;
        }

        // Properties
        public uint UniqueClassNum 
        { 
            get { return this.uniqueClassNum; }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {this.uniqueClassNum = value;}
		 	}
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
