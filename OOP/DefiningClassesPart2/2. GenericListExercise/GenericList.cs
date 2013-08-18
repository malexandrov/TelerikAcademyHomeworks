using System;
using System.Collections.Generic;
using System.Text;

namespace _2.GenericListExercise
{
    public class GenericList<T> 
        where T: IComparable<T>, new()
    {
        private T[] listElements;
        private int index;

        // Constructor
        public GenericList (int capacity)
        {
            this.listElements = new T[capacity];
        }

        // Methods
        public void Add(T element)
        {
            if (index > listElements.Length - 1)
            {
                Autogrow();
            }

            this.listElements[index] = element;
            index++;
        }

        private void Autogrow()
        {
            T[] tempList = new T[listElements.Length * 2];
            Array.Copy(listElements, tempList, listElements.Length);
            listElements = tempList;
        }

        public T this[int index] 
        {
            get
            {
                if (index >= 0 && index < listElements.Length)
                {
                    return listElements[index];
                }

                else 
                { 
                    throw new ArgumentOutOfRangeException("Index out of range!"); 
                }
            }

            set 
            { 
                this.listElements[index] = value; 
            } 
        }

        public void ClearList()
        {
            this.listElements = new T[listElements.Length];
        }

        public void InsertElement(int position, T element)
        {
            if (position >= 0 && position <= listElements.Length)
            {
                T[] tempList = new T[listElements.Length + 1];
                Array.Copy(listElements, tempList, position );
                tempList[position] = element;
                Array.Copy(listElements, position, tempList, position + 1, listElements.Length - position);
                listElements = tempList;
                this.index++;
            }

            else 
            { 
                throw new ArgumentOutOfRangeException("Index out of range!"); 
            }
        }

        public void RemoveElement(int position)
        {
            if (position >= 0 && position < listElements.Length)
            {
                T[] tempList = new T[listElements.Length - 1];

                Array.Copy(listElements, position + 1, tempList, position, listElements.Length - position - 1);
                Array.Copy(listElements, tempList, position);
                listElements = tempList;
                this.index--;
            }

            else 
            { 
                throw new ArgumentOutOfRangeException("Index out of range!"); 
            }
        }

        public int IndexByValue(T value)
        {
            return Array.IndexOf(listElements, value);
        }

        public U Min<U>() where U: IComparable<U>, new()
        {
            dynamic minElement = this.listElements[0] ;

            for (int i = 1; i < listElements.Length; i++)
            {
                if (listElements[i].CompareTo(minElement) < 0)
                {
                    minElement = listElements[i];
                }
            }
            return minElement;
        }

        public Y Max<Y>() where Y : IComparable<Y>
        {
            dynamic maxElement = listElements[0];

            for (int i = 1; i < listElements.Length; i++)
            {
                if (listElements[i].CompareTo(maxElement) > 0)
                {
                    maxElement = listElements[i];
                }
            }
            return maxElement;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listElements.Length; i++)
            {
                sb.AppendLine("Element " + i + " = " + listElements[i]);
            }
            return sb.ToString();
        }
    }
}
