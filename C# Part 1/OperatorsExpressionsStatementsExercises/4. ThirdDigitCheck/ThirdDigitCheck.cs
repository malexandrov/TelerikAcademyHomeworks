using System;

class ThirdDigitCheck
{
    static void Main()
    {
        int givenInt = 1734;
        string givenIntStr = Convert.ToString(givenInt);
        int displace = givenIntStr.Length - 3;
        Console.WriteLine(givenIntStr[displace] == '7');
    }
}