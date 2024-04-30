using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class NonGeneric
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList(20);

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("Hello");
            arrayList.Add(24.35);
            arrayList.Add((int)1.54);
            arrayList.Add('G');

            foreach(object obj in arrayList)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
