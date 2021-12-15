using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.MenuItems
{
    public class MenuItemCalc : MenuItemCore
    {
        public override string Title { get { return "Calc: Y + sqrt(X % Z)"; } }

        public override void Execute()
        {
            Console.WriteLine("You chose to solve Y+sqrt(X % Z)");

            double Result = IOUtils.getResultEquation();
            Console.WriteLine("Thw result is:    ");
            Console.WriteLine("{0:0.###} \n", Result);
            Console.ResetColor();
        }
    }
}
