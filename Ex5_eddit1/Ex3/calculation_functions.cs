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

        public static double getResultEquation(int iX, int iY, int iZ)
        {
            while (true)
            {
                

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
            TimeSpan N = TimeSpan.Zero;
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

        public static int getResultDate(DateTime date1_0, DateTime date1_1, DateTime date2_0, DateTime date2_1)
        {
            int N = (calculation_functions.DatePeriod(date1_0, date1_1, date2_0, date2_1)).Days;
            Console.WriteLine("The period between dates is: {0}", N);
            IsPowerOfTwo(N);
            return N;
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