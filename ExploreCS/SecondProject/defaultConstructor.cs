using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class defaultConstructor
    {
        // default or implicit constructor
        int i;
        bool b;

        static void Main(string[] args)
        {
            defaultConstructor d= new defaultConstructor();
            Console.WriteLine(d.i);
            Console.WriteLine(d.b);
            Console.ReadLine();
        }
    }
}
