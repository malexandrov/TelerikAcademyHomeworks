using System;

class TestProgram
{
    static void Main()
    {
        Console.WriteLine(MathUtils.CalcPointsDistance(3, 4, 5,6));

        Console.WriteLine(TextUtils.ConvertDigitToWord(5));

        Console.WriteLine(MathUtils.FindMax(5, -1, 3, 2, 14, 2, 3));

        TextUtils.PrintAsNumber(1.3, "f");
        TextUtils.PrintAsNumber(0.75, "%");
        TextUtils.PrintAsNumber(2.30, "r");


        Console.WriteLine(MathUtils.CalcPointsDistance(3, -1, 3, 2.5));
        Console.WriteLine("Horizontal? " + MathUtils.IsLineHorizontal(3, -1, 3, 2.5));
        Console.WriteLine("Vertical? " + MathUtils.IsLineVertical(3, -1, 3, 2.5));

        Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 03, 17));
        peter.Comment = "From Sofia";

        Student stella = new Student("Stella", "Markova", new DateTime(1993, 03, 11));
        stella.Comment = "From Vidin, gamer, high results";

        Console.WriteLine("{0} older than {1} -> {2}",
            peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
    }
}
