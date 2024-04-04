using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
     interface InterfaceTest1
    {
        void add(int a, int b);
    }

   interface InterfaceTest2 : InterfaceTest1
    {
        void sub(int a, int b);
    }

    class InterfaceClass : InterfaceTest2
    {
        public void add(int a, int b) {

            Console.WriteLine(a+b);
        }

        public void sub(int a, int b)
        { Console.WriteLine(a - b); }

        public static void Main(string[] args)
        {
            InterfaceClass test = new InterfaceClass();
            test.add(1, 2);
            test.sub(7, 2);
        }
    }

    
}
