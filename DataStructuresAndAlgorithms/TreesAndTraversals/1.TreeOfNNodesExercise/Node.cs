using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeOfNNodesExercise
{
    public class Node<T>
    {
        private T value;
        private List<Node<T>> children;
        private Node<T> parent;

        public Node<T> Parent
        {
            get { return this.parent; }
            set { this.parent = value; }
        }
        
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public List<Node<T>> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }
        
        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public Node(T value): this()
        {
            this.Value = value;
        }


    }
}
