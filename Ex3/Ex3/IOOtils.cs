using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.Specification;

namespace Ex3
{
    public class IOUtils
    {
        public static IDictionary<string, string> ExternalValues = null;

        public static void SetExtValues(IDictionary<string, string> values)
        {
            ExternalValues = values;
        }
        public static int SafeReadInteger(string message, ISpecification<int> specification = null) //ввести число int
        {
            while (true)
            {
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine(message);
                }
                string sValue = Console.ReadLine();
                int iValue = 0;
                if (Int32.TryParse(sValue, out iValue))
                {
                    try
                    {
                        if (specification != null)
                        {
                            specification.Validate(iValue);
                        }
                        return iValue;
                    }
                    catch (ValidationException ex)
                    {
                        Console.WriteLine("ERROR: " + ex);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Incorrect format. Enter Integer value... ");
                }

            }
        }
        /*public static DateTime SafeReadDate(string message) // ввести дату произвольного формата
        {
            while (true)
            {
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine(message);
                }
                string sValue = Console.ReadLine();
                DateTime date;
                if (DateTime.TryParse(sValue, out date))
                {
                    Console.WriteLine("Value is {0}.{1}.{2}\n", date.Day, date.Month, date.Year);
                    return date;
                }
                Console.WriteLine("ERROR: Incorrect format. Enter correct date time... ");
            }
        }*/



        public static double getResultEquation() // решение уравнения
        {
            while (true)
            {
                Console.WriteLine("Enter integer X");
                int iX = SafeReadInteger(null);
                Console.WriteLine("Enter integer Y");
                int iY = SafeReadInteger(null);
                Console.WriteLine("Enter integer Z");
                int iZ = SafeReadInteger("Enter integer Z", new IsNotZero() );

                if (iZ != 0)
                {
                    if ((iX % iZ) >= 0)
                    {
                        double Result = iY + Math.Sqrt(iX % iZ);

                        return Result;
                    }
                    Console.WriteLine("Ошибка ввода! Введите целое числа (iX % iZ) >= 0\n");
                }
                Console.WriteLine("Ошибка ввода! Введите целое число iZ != 0\n");
            }

        }

        private static string GetValue(string paramName, string message) //считывает значение
        {
            string sValue = null;
            if (ExternalValues == null)
            {
                sValue = Console.ReadLine();
            }
            else
            {
                if (!ExternalValues.TryGetValue(paramName, out sValue))
                {
                    throw new InvalidOperationException(string.Format("Parameter -{0} not specify.", paramName));
                }
            }
            return sValue;
        }

        public static DateTime SafeReadDate(string paramName, string message) // считать дату dd.MM.yyyy
        {
            if (ExternalValues == null && !string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = GetValue(paramName, message);
                try
                {
                    DateTime date = DateTime.ParseExact(sValue, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);

                    return date;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    if (ExternalValues != null)
                    {
                        throw new InvalidOperationException(ex.Message, ex);
                    }
                }
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
                        int N = (DatePeriod(date1_0, date1_1, date2_0, date2_1)).Days;

                        Console.WriteLine("Enter is correct \n");

                        var days = N;

                        Console.WriteLine(days);

                        double logX = Math.Log(days, 2);

                        if (logX % 1 == 0)
                        {
                            Console.WriteLine("YES, {0} is a degree of 2 \n", days);

                            return days;


                        }
                        else if (logX % 1 != 0)
                        {
                            Console.WriteLine("NO, {0} is NOT a degree of 2 \n", days);

                            return days;
                        }



                    }
                    Console.WriteLine("Введите 2_0 дату такую, чтобы она была меньше 2_1: ");
                }
                Console.WriteLine("Введите 1_0 дату такую, чтобы она была меньше 1_1: ");


            }
        }

        
    }
}

    
