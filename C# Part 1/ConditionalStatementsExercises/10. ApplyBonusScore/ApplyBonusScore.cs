using System;
//Напишете програма, която прилага бонус точки към дадени точки в
//интервала [1..9] чрез прилагане на следните правила:
//- Ако точките са между 1 и 3, програмата ги умножава по 10.
//- Ако точките са между 4 и 6, ги умножава по 100.
//- Ако точките са между 7 и 9, ги умножава по 1000.
//- Ако точките Ако точките са 0 или повече от 9, се отпечатва съобщение за грешка.


class ApplyBonusScore
{
    static void Main()
    {
        int score;
        Console.WriteLine("Please enter score:");
        bool check = int.TryParse(Console.ReadLine(), out score);

        switch (score)
        {
            case 1:
            case 2:
            case 3:
                {
                    score = score * 10;
                    Console.WriteLine("The score with added bonus is: {0}", score);
                    break;
                }
            case 4:
            case 5:
            case 6:
                {
                    score = score * 100;
                    Console.WriteLine("The score with added bonus is: {0}", score);
                    break;
                }
            case 7:
            case 8:
            case 9:
                {
                    score = score * 1000;
                    Console.WriteLine("The score with added bonus is: {0}", score);
                    break;
                }
            default:
                {
                    Console.WriteLine("Bad score input!!");
                    break;
                }
        }
    }
}
