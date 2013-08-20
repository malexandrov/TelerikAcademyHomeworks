using System;

class VisitCellExercise
{
    public void Main()
    {
        int x = 5;
        int y = 5;
        int minX = 1;
        int maxX = 10;
        int minY = 1;
        int maxY = 10;
        bool shouldVisitCell = false;

        // Refactor the following if statement: 
        //        if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
        //          {
        //              VisitCell();
        //          }
  
        if (shouldVisitCell)
        {
            if (minX <= x && x <= maxX)
            {
                if (minY <= y && y <= maxY)
                {
                    VisitCell();
                }
            }
        }
    }

    public void VisitCell()
    {
        //..
    }
}
