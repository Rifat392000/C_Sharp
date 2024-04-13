using Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
    internal static class AddMethod
    {
        public static void Test3(this Program p)
        {
            Console.WriteLine("Method 3");
        }

        public static void Test3(this Program p, int i)
        {
            Console.WriteLine("Method "+i);
        }

        public static long Factorial(this Int32 x)
        {
            if (x == 1)
            {
                return 1;
            }
            if(x == 2)
            {
                return 2;
            }
            else
                return x*Factorial(x-1);
        }

        public static string ToProper(this String oldStr)
        {
            if (oldStr.Trim().Length > 0)
            {
                string newStr = null;
                oldStr = oldStr.ToLower();
                string[] str = oldStr.Split(' ');

                foreach (string s in str)
                {
                    char[] ch = s.ToCharArray();
                    ch[0] = Char.ToUpper(ch[0]);
                    newStr += new string(ch);
                    newStr += " ";
                }

                return newStr;
            }
            else
            {
                return oldStr;
            }
        }
    }
    


}
