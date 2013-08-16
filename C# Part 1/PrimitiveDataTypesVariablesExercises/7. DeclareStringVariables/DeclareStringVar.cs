using System;

class DeclareStringVar
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object concatination = a +" "+ b;
        string result = (string)concatination;
        Console.WriteLine(result);
    }
}

