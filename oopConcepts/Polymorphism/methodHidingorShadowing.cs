using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class methodHidingorShadowing
    {
        public void Test()
        {
            Console.WriteLine("Parent Class");
        }
    }
    class methodHidingor :methodHidingorShadowing
    {
        public new void Test()
        {
            Console.WriteLine("Child Class");
        }

        public void parentPrint()
        {
            base.Test();
        }

        public static void Main() { 
        
            new methodHidingor().Test();

            //parent class
            new methodHidingorShadowing().Test();
            new methodHidingor().parentPrint();
        }

    }
}
