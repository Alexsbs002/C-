using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.MenuItems
{
    public class MenuItemsString : MenuItemCore
    {
        public override string Title { get { return "Enter 2 strings "; } }

        public override void Execute()
        {
            Console.WriteLine("Enter 2 strings: ");
            string a = IOUtils.ReadString("Enter the 1 string : ");
            string b = IOUtils.ReadString("Enter the 2 string : ");
            StringFunctions.WorkWithString(a,b);
            Console.ResetColor();
        }
    }
}
