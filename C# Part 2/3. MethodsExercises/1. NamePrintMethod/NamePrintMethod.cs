using System;
using System.Collections.Generic;

class NamePrintMethod
{
    static void Main()
    {
        PrintName();
    }

    static void PrintName()
    {
        Console.WriteLine("What's your name?");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", userName);
    }
}