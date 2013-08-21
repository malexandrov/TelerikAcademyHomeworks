namespace BiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            BiDictionary<int, int, int> myDictionary = new BiDictionary<int, int, int>();
            myDictionary.Add(1, 2, 11);
            myDictionary.Add(1, 2, 11);
            myDictionary.Add(1, 2, 22);
            myDictionary.Add(1, 2, 33);
            myDictionary.Add(1, 2, 44);

            foreach (int i in myDictionary.FindByBothKeys(1, 2))
            {
                Console.WriteLine(i);
            }
        }
    }
}
