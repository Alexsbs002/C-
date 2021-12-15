using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3.MenuItems;

namespace Ex3
{

    class Program
    {
        static void Main(string[] args)
        {
            Menu.ClearItems();
            Menu.AddItem(new MenuItemExit());
            Menu.AddItem(new MenuItemHelloWorld());
            Menu.AddItem(new MenuItemCalc());
            Menu.AddItem(new MenuItemDate());
            while (true)
            {
                Menu.Execute();
            }

        }
    }
}