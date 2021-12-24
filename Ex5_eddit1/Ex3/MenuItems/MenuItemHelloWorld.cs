using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.MenuItems
{
    public class MenuItemHelloWorld : MenuItemCore
    {
        public override string Title { get { return "hello world!"; } }

        public override void Execute()
        {
            Console.WriteLine("TEAM SPIRIT FOREVER! \n");
        }
    }
}
