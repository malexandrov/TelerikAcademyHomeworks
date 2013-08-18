using System;

namespace _2.GenericListExercise
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            GenericList<int> testList = new GenericList<int>(5);
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);

            Console.WriteLine(testList.ToString());
            testList.RemoveElement(4);
            testList.Add(321);
            Console.WriteLine(testList.ToString());
            Console.WriteLine(testList.Max<int>());
            Console.WriteLine(testList.Min<int>());
        }
    }
}
