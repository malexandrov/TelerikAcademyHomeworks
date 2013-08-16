using System;

class StringVarEscapingSequence
{
    static void Main()
    {
        string firstVariant = @"The ""Use"" of quotations causes difficulties.";
        string secondVariant = "The \"Use\" of quotations causes difficulties.";
        Console.WriteLine(firstVariant);
        Console.WriteLine(secondVariant);
    }
}
