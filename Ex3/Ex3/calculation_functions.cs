using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.Specification;

namespace Ex3
{
    class calculation_functions
    {

        public static double getResultEquation()
        {
            while (true)
            {
                Console.WriteLine("Enter integer X");
                int iX = IOUtils.SafeReadInteger(null);
                Console.WriteLine("Enter integer Y");
                int iY = IOUtils.SafeReadInteger(null);
                Console.WriteLine("Enter integer Z");
                int iZ = IOUtils.SafeReadInteger("Enter integer Z", new IsNotZero());

                    if ((iX % iZ) >= 0)
                    {
                        double Result = iY + Math.Sqrt(iX % iZ);

                        return Result;
                    }
                    Console.WriteLine("Ошибка ввода! Введите целое числа (iX % iZ) >= 0\n");
            }
        }

        public static TimeSpan DatePeriod(DateTime date1_0, DateTime date1_1, DateTime date2_0, DateTime date2_1)
        {
            TimeSpan N = new TimeSpan(0, 0, 0);
            if ((date2_1 >= date1_0) && (date1_1 >= date2_0))
            {
                if (date2_0 >= date1_0)
                {
                    if (date1_1 >= date2_1)
                    {
                        return (date2_1 - date2_0 + TimeSpan.FromDays(1));
                    }
                    return (date2_1 - date2_0 + TimeSpan.FromDays(1));
                }
                if (date2_1 >= date1_1)
                {
                    return (date1_1 - date1_0 + TimeSpan.FromDays(1));
                }
                return (date2_1 - date1_0 + TimeSpan.FromDays(1));
            }
            return N;
        }

        public static int getResultDate()
        {

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
                        int N = (calculation_functions.DatePeriod(date1_0, date1_1, date2_0, date2_1)).Days;
                        Console.WriteLine("The period between dates is: {0}",N);
                        IsPowerOfTwo(N);
                        return N;
                    }
                    Console.WriteLine("Введите 2_0 дату такую, чтобы она была меньше 2_1: ");
                }
                Console.WriteLine("Введите 1_0 дату такую, чтобы она была меньше 1_1: ");


            }
        }
        public static bool IsPowerOfTwo(int number)
        {
            for (int x = 1; x <= number; x *= 2)
            {
                if (x == number)
                {
                    Console.WriteLine("The period between dates is power of two ");
                    return true;
                }

                
            }
            Console.WriteLine("The period between dates is not power of two");
            return false;
        }

    }
}