using System;

class CheckForSubstringRepeat
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int counter = 0;
        int index = 0;
        string newString = text.ToLower();
        do
        {
            index = newString.IndexOf("in", index+1);
            if (index != -1)
            {
                counter++;
            }
        }
        while (index != -1);
        Console.WriteLine(counter);
    }
}