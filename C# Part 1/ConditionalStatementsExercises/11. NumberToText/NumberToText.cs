using System;
using System.Text;

class Program
{
    static void Main()
    {
        int number = 1000;
        while (0 > number || number > 999)
            {
                Console.Write("Enter integer between 0 and 999: ");
                bool check = int.TryParse(Console.ReadLine(), out number);
            }

        int thirdDigit = number % 10;
        int secondDigit = (number / 10) % 10;
        int firstDigit = number / 100;
        string[] ones = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        string[] special = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        string[] tens = {"twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};
        StringBuilder text = new StringBuilder();

        if (firstDigit != 0)
        {
            if (secondDigit != 0)
            {
                text.Append(ones[firstDigit] + " hundred and ");
            }
            else text.Append(ones[firstDigit] + " hundred");
        }

        switch (secondDigit)
        {
            case 1: text.Append(special[thirdDigit]); break;
            case 0: if (thirdDigit == 0 && firstDigit == 0) text.Append("zero"); break;
            default: text.Append(tens[secondDigit-2]); break;
        }

        if (secondDigit != 1 && text.ToString() != "zero")
        {
            if (thirdDigit != 0)
            {
                if (secondDigit != 0) text.Append(" ");
                text.Append(ones[thirdDigit]);
            }
        }
        text[0] -= (char)32;
        Console.WriteLine(text + ".\n");
    }
}
