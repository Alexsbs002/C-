using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.Specification;

namespace Ex3.MenuItems
{
    public class MenuItemCalc : MenuItemCore
    {
        public override string Title { get { return "Calc: Y + sqrt(X % Z)"; } }

        public override void Execute()
        {
            Console.WriteLine("You chose to solve Y+sqrt(X % Z)");

            Console.WriteLine("Enter integer X");
            int iX = IOUtils.SafeReadInteger(null);
            Console.WriteLine("Enter integer Y");
            int iY = IOUtils.SafeReadInteger(null);
            Console.WriteLine("Enter integer Z");
            int iZ = IOUtils.SafeReadInteger("Enter integer Z", new IsNotZero());
            double Result = calculation_functions.getResultEquation(iX, iY, iZ);
            Console.WriteLine("Thw result is:    ");
            Console.WriteLine("{0:0.###} \n", Result);
            Console.ResetColor();
        }
    }
}
