using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Collections
{
    internal class Generic
    {
       

        public static bool Compare1(object obj1, object obj2)
        {
            if(obj1.Equals(obj2)) return true;

            return false;
        }

        public static bool Compare2 <T> (T obj1, T obj2)
        {
            if (obj1.Equals(obj2)) return true;

            return false;
        }


        public static void Main(string[] args)
        {
            List<int> li = new List<int>();

            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(4);

            for(int i=0; i< li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }

            foreach(int i in li)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(Compare1(24,25));
            Console.WriteLine(Compare1(2.24f, 2.24f));
            Console.WriteLine(Compare2<float>(2.24f, 2.24f));
            Console.WriteLine(Compare2<int>(26, 26));
        }
    }
}
