using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(24); al.Add(240); al.Add(214); al.Add(124); al.Add(24544);

            al.Insert(2,54);
            al.Remove(214);
            al.RemoveAt(1);
            al.RemoveRange(0, 3);

            foreach(object obj in al)
            {
                Console.WriteLine(obj);
            }


            Hashtable ht = new Hashtable();
            ht.Add("Eid", 1010);
            ht.Add("Ename", "Scott");
            ht.Add("Job", "Manager");
            ht.Add("Salary", 25000.00);
            ht.Add("Mgrid", 1002);
            ht.Add("Phone", "23746666");
            ht.Add("Email", "scott@gmail.com");
            ht.Add("Dname", "Sales");
            ht.Add("Location", "Mumbai");
            ht.Add("Did", 30);

            Console.WriteLine();

            Console.WriteLine(ht["Email"]);

            Console.WriteLine();

            foreach (object k in ht.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine();

            foreach (object v in ht.Values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine();

            foreach (object k in ht.Keys)
            {
                Console.WriteLine(ht[k]);
            }




        }
    }
}
