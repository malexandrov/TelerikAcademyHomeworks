using System;
using System.Collections.Generic;

class FindPrimeNumbers
{
    static void Main()
    {
        bool[] allNumbers = new bool[10000000];
        List<int> primeNumbers = new List<int>(10000000);  // List to storage the prime numbers

        for (int i = 0; i < allNumbers.Length; i++)
        {
            allNumbers[i] = true;
        }

        for (int i = 2; i < Math.Sqrt(allNumbers.Length); i++)
        {
            if (allNumbers[i] == true)
            {
                for (int j = i*i; j < allNumbers.Length; j = j+i)
                {
                    allNumbers[j] = false;
                }
            }
        }

        for (int i = 1; i < allNumbers.Length; i++)       // Add the prime numbers to the List
        {
            if (allNumbers[i] == true)
            {
                primeNumbers.Add(i);
            }
        }
        primeNumbers.TrimExcess();                        // Set the capacity of the list to the actual number of elements

        //foreach (var number in primeNumbers)           // Print the prime numebrs to the console
        //{
        //    Console.Write(number + " ");
        //}
    }
}
