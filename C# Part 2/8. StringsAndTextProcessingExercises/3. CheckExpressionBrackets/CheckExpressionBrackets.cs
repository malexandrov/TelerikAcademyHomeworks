using System;

class CheckExpressionBrackets
{
    static void Main()
    {
        string expression = "()a+b)/5-d(";
        int bracketCount = 0;

        for (int i = 0; i < expression.Length && bracketCount >=0; i++)
        {
            if (expression[i] == '(')
            {
                bracketCount++;
            }
            if (expression[i] == ')')
            {
                bracketCount--;
            }
        }
        Console.WriteLine((bracketCount != 0) ? "Incorrect!" : "Correct!");
    }
}