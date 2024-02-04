using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class staticVsNon
    {
        int x;
        static int y;

        static void withoutParameter()
        {
            
            Console.WriteLine("withoutParameter");
        }
        static void withParameter(int val, string name)
        {
            Console.WriteLine(name + ": " + val);
            Console.WriteLine("withParameter");
        }

        public static void Main(string[] args)
        {
            // In static field we can acess directly into the static methods without create an any instances whereas 
            // we non static field we can only access if we create object instances and this is beacuse static fiels always provide the same value

            Console.WriteLine(y);
            withoutParameter();
            withParameter(24, "Rifat");
            
        }
    }
}
