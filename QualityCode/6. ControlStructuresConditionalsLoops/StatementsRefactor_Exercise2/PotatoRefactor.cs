using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PotatoRefactor
{
    public static void Main(string[] args)
    {
        Potato potato = new Potato();
        Chef chef = new Chef();

        // Refactor the following if statements: 
        //Potato potato;
        ////... 
        //if (potato != null)
        //    if (!potato.HasNotBeenPeeled && !potato.IsRotten)
        //        Cook(potato);

        if (potato != null)
        {
            if (potato.HasBeenPeeled && potato.IsFresh)
            {
                chef.Cook(potato);
            }

        }
    }
}
