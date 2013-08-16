using System;

class SubsetSum
{
    static void Main()
    {
        int[] intArray = new int[5];
        Console.WriteLine("Please enter five integers:");
        for (int i = 0; i < 5; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < intArray.Length - 2; i++)
        {
            for (int two = i + 1; two < intArray.Length; two++)
            {
                if (intArray[i] + intArray[two] == 0)
                {
                    Console.WriteLine("<{0}, {1}> = 0", intArray[i], intArray[two]);
                }
                for (int three = two + 1; three < intArray.Length; three++)
                {
                    if (intArray[i] + intArray[two] + intArray[three] == 0)
                    {
                        Console.WriteLine("<{0}, {1}, {2}> = 0", intArray[i], intArray[two], intArray[three]);
                    }
                    for (int four = three + 1; four < intArray.Length; four++)
                    {
                        if (intArray[i] + intArray[two] + intArray[three] + intArray[four] == 0)
                        {
                            Console.WriteLine("<{0},{1},{2},{3}> = 0", intArray[i], intArray[two], intArray[three], intArray[four]);
                        }
                    }
                }
            }
        }
    }
}
