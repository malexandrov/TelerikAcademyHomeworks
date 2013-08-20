using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopRefactor
{
    class LoopRefactor
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] array = new int[100];
            int expectedValue = 5;

            for (i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
                Console.WriteLine(array[i]);
            }
        }
    }
}
