using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.MenuItems
{
    class MenuItemDate : MenuItemCore
    {
        public override string Title { get { return "Recursion date"; } }

        public override void Execute()
        {
            Console.WriteLine("Enter 2 dates in format  dd.mm.yyyy");

            IOUtils.getResultDate();
            Console.ResetColor();
        }
    }
}
