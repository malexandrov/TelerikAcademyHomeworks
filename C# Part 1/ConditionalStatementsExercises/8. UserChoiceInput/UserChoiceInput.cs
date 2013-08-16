using System;

class UserChoiceInput
{
    static void Main()
    {
        Console.WriteLine("Please enter 1 for integer, 2 for double, 3 for string:");
        int inputType = int.Parse(Console.ReadLine());

        switch (inputType)
        {
            case 1:
                {
                    Console.WriteLine("Please enter integer value:");
                    int inputInt = int.Parse(Console.ReadLine());
                    inputInt++;
                    Console.WriteLine(inputInt);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Please enter double value:");
                    double inputDouble = double.Parse(Console.ReadLine());
                    inputDouble++;
                    Console.WriteLine(inputDouble);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Please enter stringvalue:");
                    string inputString = Console.ReadLine();
                    inputString = inputString + "*";
                    Console.WriteLine(inputString);
                    break;
                }
        }
    }
}