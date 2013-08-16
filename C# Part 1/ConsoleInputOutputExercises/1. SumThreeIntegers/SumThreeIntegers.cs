using System;

class SumThreeIntegers
{
    static void Main()
    {
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of {0}, {1} and {2} is {3}", 
            firstInt, secondInt, thirdInt, (firstInt + secondInt + thirdInt));
    }
}
