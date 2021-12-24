using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.MenuItems
{
    public class MenuItemDate : MenuItemCore
    {
        public override string Title { get { return "Recursion date"; } }

        public override void Execute()
        {
            Console.WriteLine("Enter 4 dates in format  dd.mm.yyyy");

            while (true)
            {
                DateTime date1_0;
                DateTime date1_1;
                DateTime date2_0;
                DateTime date2_1;

                do
                {
                    date1_0 = IOUtils.SafeReadDate(null, "enter the 1 date:");
                    date1_1 = IOUtils.SafeReadDate(null, "enter the 2 date:");

                    if (date1_0 > date1_1)
                    {
                        Console.WriteLine("the beginning of the 1st segment should be less than its end");
                    }
                } while (date1_0 > date1_1);

                do
                {
                    date2_0 = IOUtils.SafeReadDate(null, "enter the 3 date:");
                    date2_1 = IOUtils.SafeReadDate(null, "enter the 4 date:");
                    if (date2_0 > date2_1)
                    {
                        Console.WriteLine("the beginning of the 2nd segment should be less than its end");
                    }
                } while (date2_0 > date2_1);

                if (date1_1 >= date1_0)
                {
                    if (date2_1 >= date2_0)
                    {
                        calculation_functions.getResultDate(date1_0, date1_1, date2_0, date2_1);
                        
                    }
                    else
                    Console.WriteLine("Введите 2_0 дату такую, чтобы она была меньше 2_1: ");
                }
                else
                Console.WriteLine("Введите 1_0 дату такую, чтобы она была меньше 1_1: ");

                break;
            }
            
           
        }
    }
}
