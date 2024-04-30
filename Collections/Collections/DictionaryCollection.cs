using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class DictionaryCollection
    {
      

            public static void Main(string[] args)
        {
            Dictionary<string, object> ht = new Dictionary<string, object>();

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

            foreach (string k in ht.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine();

            foreach (object v in ht.Values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine();

            foreach (string k in ht.Keys)
            {
                Console.WriteLine(k + " : "+ht[k]);
            }
        }


    }
}
