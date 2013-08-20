using System;

// Refactor the following class using best practices for organizing straight-line code:
public class Chef
{
    private Bowl bowl;
    private Vegetable potato;
    private Vegetable carrot;

    private Bowl GetBowl()
    {
        return new Bowl();
    }
    private Carrot GetCarrot()
    {
        return new Carrot();
    }
    private Potato GetPotato()
    {
        return new Potato();
    }

    private void Cut(Vegetable vegetable)
    {
        //...
    }

    private void Peel(Vegetable vegetable)
    {
        //...
    }

    public void Cook(Vegetable vegetable)
    {
        Peel(vegetable);
        Cut(vegetable);
        bowl = GetBowl();
        bowl.Add(vegetable);

    }
}

