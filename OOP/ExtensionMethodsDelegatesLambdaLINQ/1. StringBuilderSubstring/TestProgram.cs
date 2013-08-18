using System;
using System.Text;

namespace _1.StringBuilderSubstring
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            StringBuilder testSB = new StringBuilder();
            testSB.Append("There");
            Console.WriteLine(testSB.Substring(2,3));
        }
    }
}
