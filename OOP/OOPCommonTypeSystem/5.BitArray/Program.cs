using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 arr = new BitArray64(800);

            foreach (var item in arr)
            {
                Console.Write(item);
            }

            BitArray64 arr2 = new BitArray64(256);

            Console.WriteLine();
            Console.WriteLine("Check for equality: {0}", arr.Equals(arr2));
            Console.WriteLine("Check for equality: {0}", arr == arr2);
            Console.WriteLine("Print HashCode arr: " + arr.GetHashCode());
            Console.WriteLine("Print HashCode arr2: " + arr2.GetHashCode());
            Console.WriteLine("Element at position: " + arr2[62]);



        }
    }
}
