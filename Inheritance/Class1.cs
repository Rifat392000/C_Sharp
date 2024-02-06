using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class1:Program
    {
        public void Test3()
        {
            Console.WriteLine("Child Class Test 3 ");
        }

        public Class1()
        {
            Console.WriteLine("Child class");
        }

        public Class1(int v1, string v2):base(v1, v2) 
        {
            Console.WriteLine("Parameter pass parent class successful");
            Console.WriteLine("Hello "+v2+ " your id is " + v1);
        }
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.Test1();
            class1.Test2();
            class1.Test3();
            Class1 c = new Class1(215,"Rifat");

            Program P;
            P = class1;
            P.Test1();
            P.Test2();

            Object obj =new object();
            Console.WriteLine(obj.GetType());
            Console.WriteLine(P.GetType());
            Console.WriteLine(class1.GetType());
        }
    }
}
