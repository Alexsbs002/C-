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

        public static string ReadString(string message, ISpecification<string> specification = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            string sValue = Console.ReadLine();

            try
            {
                if (specification != null)
                {
                    specification.Validate(sValue);
                }
                return sValue;
            }
            catch (ValidationException ex)
            {
                Console.WriteLine("ERROR: " + ex);
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
    }
}

    
