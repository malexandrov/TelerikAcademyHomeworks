namespace HastTableImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class HastTableImplementation
    {
        static void Main(string[] args)
        {
            HashTable<int, int> hashTable = new HashTable<int, int>();
            Console.WriteLine("count: " + hashTable.Count);
            for (int i = 0; i < 10; i++)
            {
                hashTable.Add(i, i + 1);
            }

            hashTable.Remove(5);

            foreach (var item in hashTable)
            {
                Console.WriteLine("Key {0}, Value {1}", item.Key, item.Value);
            }
            Console.WriteLine("count: " + hashTable.Count);

            Console.WriteLine("Element at position 3: " + hashTable.Find(3));

            hashTable.Clear();
            Console.WriteLine("After clear: " + hashTable.Count);
        }
    }
}
