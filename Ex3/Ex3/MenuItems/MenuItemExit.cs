using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.MenuItems
{
    public class MenuItemExit : MenuItemCore
    {
        public override string Title { get { return "Exit"; } }
        public override void Execute()
        {
            Console.WriteLine("Exit...\n");
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}
