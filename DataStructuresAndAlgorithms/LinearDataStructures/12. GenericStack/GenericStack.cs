using System;

namespace GenericStack
{
    class GenericStack
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>(10);
            for (int i = 0; i < 10; i++)
            {
                myStack.Push(i);
            }
            Console.WriteLine(myStack);
          
            // Resize
            myStack.Push(10);
            Console.WriteLine(myStack);
          
            // Pop all elements
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(myStack.Pop());
            }

        }
    }
}
