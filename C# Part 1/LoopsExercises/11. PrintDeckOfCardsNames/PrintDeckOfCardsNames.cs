using System;

class PrintDeckOfCardsNames
{
    static void Main()
    {
        string[] card = new string[] {"Deuce","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King","Ace"};
        string[] color = new string[] {"clubs","diamonds","hearts","spades"};
       
        for (int i = 0; i < color.Length; i++)
        {
            for (int j = 0; j < card.Length; j++)
            {
                Console.WriteLine("{0} of {1}", card[j], color[i]);
            }
        }
    }
}
