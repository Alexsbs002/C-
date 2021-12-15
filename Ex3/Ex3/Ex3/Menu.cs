using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3.MenuItems;

namespace Ex3
{
    public class Menu
    {
        private static List<MenuItemCore> MenuItems = new List<MenuItemCore>();

        public static void ClearItems()
        {
            Menu.MenuItems.Clear();
        }

        public static void AddItem(MenuItemCore menuItem)
        {
            Menu.MenuItems.Add(menuItem);
        }

        static public void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            ShowMenu();
            int iMenu = IOUtils.SafeReadInteger(null) - 1;
            if (iMenu >= 0 && iMenu < Menu.MenuItems.Count)
            {
                MenuItems.ToArray()[iMenu].Execute();
            }
            else
            {
                Console.WriteLine("Menu item not found.");
                Console.ResetColor();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Main Menu: ");

            int iMenuItem = 1;
            foreach (MenuItemCore menuitem in MenuItems)
            {
                Console.WriteLine("{0}: {1}", iMenuItem++, menuitem.Title);
            }

        }
    }
}
