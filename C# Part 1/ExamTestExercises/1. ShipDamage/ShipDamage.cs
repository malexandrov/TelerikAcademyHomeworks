using System;

class ShipDamage
{
    static void Main()
    {
        int ship1x = int.Parse(Console.ReadLine());
        int ship1y = int.Parse(Console.ReadLine());
        int ship2x = int.Parse(Console.ReadLine());
        int ship2y = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        int Cx1 = int.Parse(Console.ReadLine());
        int Cy1 = int.Parse(Console.ReadLine());
        int Cx2 = int.Parse(Console.ReadLine());
        int Cy2 = int.Parse(Console.ReadLine());
        int Cx3 = int.Parse(Console.ReadLine());
        int Cy3 = int.Parse(Console.ReadLine());
 
        int rectangleTop = 0, rectangleBottom = 0, rectangleRight = 0, rectangleLeft = 0;
        if (ship1y > ship2y)
        {
            rectangleTop = ship1y;
            rectangleBottom = ship2y;
        }
        if (ship2y > ship1y)
        {
            rectangleTop = ship2y;
            rectangleBottom = ship1y;
        }
        if (ship1x > ship2x)
        {
            rectangleRight = ship1x;
            rectangleLeft = ship2x;
        }
        if (ship2x > ship1x)
        {
            rectangleRight = ship2x;
            rectangleLeft = ship1x;
        }
 
 
        int shot1, shot2, shot3;

        shot1 = 2 * H - Cy1;
        shot2 = 2 * H - Cy2;
        shot3 = 2 * H - Cy3;
 
        int damage = 0;

        if ((shot1 == rectangleBottom && Cx1 == rectangleRight) ||
            (shot1 == rectangleTop && Cx1 == rectangleRight) || 
            (shot1 == rectangleTop && Cx1 == rectangleLeft) || 
            (shot1 == rectangleBottom && Cx1 == rectangleLeft))
        {
            damage += 25;
        }
 
        if ((shot2 == rectangleBottom && Cx2 == rectangleRight) ||
            (shot2 == rectangleTop && Cx2 == rectangleRight) ||
            (shot2 == rectangleTop && Cx2 == rectangleLeft) || 
            (shot2 == rectangleBottom && Cx2 == rectangleLeft))
        {
            damage += 25;
        }
 
        if ((shot3 == rectangleBottom && Cx3 == rectangleRight) ||
            (shot3 == rectangleTop && Cx3 == rectangleRight) ||
            (shot3 == rectangleTop && Cx3 == rectangleLeft) ||
            (shot3 == rectangleBottom && Cx3 == rectangleLeft))
        {
            damage += 25;
        }

        if ((shot1 == rectangleBottom && Cx1 > rectangleLeft && Cx1 < rectangleRight) ||
            (shot1 == rectangleTop && Cx1 > rectangleLeft && Cx1 < rectangleRight) ||
            (Cx1 == rectangleLeft && shot1 > rectangleBottom && shot1 < rectangleTop) ||
            (Cx1 == rectangleRight && shot1 > rectangleBottom && shot1 < rectangleTop))
        {
            damage += 50;
        }
 
        if ((shot2 == rectangleBottom && Cx2 > rectangleLeft && Cx2 < rectangleRight) ||
            (shot2 == rectangleTop && Cx2 > rectangleLeft && Cx2 < rectangleRight) || 
            (Cx2 == rectangleLeft && shot2 > rectangleBottom && shot2 < rectangleTop) ||
            (Cx2 == rectangleRight && shot2 > rectangleBottom && shot2 < rectangleTop))
        {
            damage += 50;
        }
 
        if ((shot3 == rectangleBottom && Cx3 > rectangleLeft && Cx3 < rectangleRight) || 
            (shot3 == rectangleTop && Cx3 > rectangleLeft && Cx3 < rectangleRight) || 
            (Cx3 == rectangleLeft && shot3 > rectangleBottom && shot3 < rectangleTop) ||
            (Cx3 == rectangleRight && shot3 > rectangleBottom && shot3 < rectangleTop))
        {
            damage += 50;
        }

        if (shot1 < rectangleTop && shot1 > rectangleBottom && Cx1 > rectangleLeft && Cx1 < rectangleRight)
        {
            damage += 100;
        }
 
        if (shot2 < rectangleTop && shot2 > rectangleBottom && Cx2 > rectangleLeft && Cx2 < rectangleRight)
        {
            damage += 100;
        }
 
        if (shot3 < rectangleTop && shot3 > rectangleBottom && Cx3 > rectangleLeft && Cx3 < rectangleRight)
        {
            damage += 100;
        }
        Console.WriteLine(damage + "%");
    }
}
