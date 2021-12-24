using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ex03.Specification;


namespace Ex3
{
    public class StringFunctions
    {
        public static bool Eq(string a, string b)
        {
            if (a.Length != b.Length)
            { 
                Console.WriteLine("is not equal\n");
                return false;
            }

            for (int i = 0; i < a.Length; i++)
                if (Math.Abs(a[i] - b[i]) > 1)
                {
                    Console.WriteLine("is not equal\n");
                    return false;
                }
            Console.WriteLine("is equal\n");
            return true;
        }

        

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static void ReverseStringCompare(string s, string b)
        {
            s = ReverseString(s);
            Console.WriteLine(" This 2 REVERCE strings..:\n");
            Eq(s, b);
        }
        public static void FullCompare(string a, string b)
        {
            a = a.Trim();
            b = b.Trim();
            a = a.ToLower();
            b = b.ToLower();

            while (a.Contains("  ") || b.Contains("  "))
            { 
                a = a.Replace("  ", " ");
                b = b.Replace("  ", " ");
            }


            Console.WriteLine("After some kind of transformation, {0} this is first string", a);
            Console.WriteLine("After some kind of transformation, {0} this is second string", b);
            Eq(a, b);


        }

        public static void IsMail(string str, int number) 
        {
            string pattern = "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+";
            Match isMatch = Regex.Match(str.ToLower(), pattern, RegexOptions.IgnoreCase);
            
            if (isMatch.Success)
            {
                Console.WriteLine("string {0} does contain an email", number);
            }

        }
        public static void IsNumber(string str, int number)
        {
            string pattern = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";
            Match isMatch = Regex.Match(str.ToLower(), pattern, RegexOptions.IgnoreCase);
            
            if (isMatch.Success)
            {
                Console.WriteLine("string {0} does contain a number", number);
            }

        }
        public static void IsIP(string str, int number)
        {
            string pattern = "(\\b25[0-5]|\\b2[0-4][0-9]|\\b[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
            Match isMatch = Regex.Match(str.ToLower(), pattern, RegexOptions.IgnoreCase);
            
            if (isMatch.Success)
            {
                Console.WriteLine("string {0} does contain an IP", number);
            }

        }

        public static void IsPhoneIpEmail(string a, string b)
        {
            IsMail(a, 1);
            IsNumber(a, 1);
            IsIP(a, 1);
            IsMail(b, 2);
            IsNumber(b, 2);
            IsIP(b, 2);
        }

        public static void WorkWithString(string a, string b)
        {
            
            Console.WriteLine("1 check ==> equality of 2 strings\n");
            Eq(a, b);
            Console.WriteLine("2 check ==> soft compare\n");
            FullCompare(a, b);
            Console.WriteLine("3 check ==> reverse compare\n");
            ReverseStringCompare(a, b);
            Console.WriteLine("4 check ==> IP/PhoneNumber/Email check\n");
            IsPhoneIpEmail(a,b);
        }
    }
}
