using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // overloading is all about defining multiple behaviours to a methods
    internal class overloading 
    {
        public void Test1()
        {
            Console.WriteLine("Pass 1");
        }

        public void Test1(int value)
        {
            Console.WriteLine("Pass 2 "+value);
        }

        public void Test1(string name)
        {
            Console.WriteLine("Pass 3 "+name);
        }

        public void Test1(int value , string name)
        {
            Console.WriteLine("Pass 4 " + value + " " + name);
        }

        public void Test1(string name, int value)
        {
            Console.WriteLine("Pass 5 " + value + " " + name);
        }

    }

    internal class class2:overloading
    {
        public void Test1(int value, string name, int id)
        {
            Console.WriteLine("Pass 6");
        }
        public static void Main(string[] args)
        {

            class2 c = new class2();
            c.Test1();
            c.Test1(10);
            c.Test1("Hello");
            c.Test1(14, "ÖMG");
            c.Test1("YEP", 45);
            c.Test1(14, "Long", 4547);
        }

    }
}
