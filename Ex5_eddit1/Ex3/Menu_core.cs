using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3.MenuItems;

namespace Ex3
{

    class Menu_core
    {
        static void Main(string[] args)
        {
            Menu_list.ClearItems();
            Menu_list.AddItem(new MenuItemExit());
            Menu_list.AddItem(new MenuItemHelloWorld());
            Menu_list.AddItem(new MenuItemCalc());
            Menu_list.AddItem(new MenuItemDate());
            Menu_list.AddItem(new MenuItemsString());
            while (true)
            {
                Menu_list.Execute();
            }

        }
    }
}