using System;

class TagsToUppercase
{
    static void Main()
    {
        string str = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        int start = 0;
        int end = 0;
        Console.WriteLine(str);

        for (int i = 0; i < str.Length - 8; i++)
        {
            if (str.Substring(i, 8) == "<upcase>")
            {
                start = i + 8;
                i = start;
            }
            if (str.Substring(i, 9) == "</upcase>")
            {
                end = i;
                int length = end - start;
                string upperStr = str.Substring(start, length).ToUpper();
                str = str.Remove(start, length);
                str = str.Insert(start, upperStr);
                str = str.Remove(start - 8, 8);
                str = str.Remove(end - 8, 9);
            }
        }
        Console.WriteLine(str);
    }
}