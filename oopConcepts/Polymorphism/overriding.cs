using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // overriding is all about changing the behaviour of parent's method under the child class
    internal class overriding
    {
        public virtual void Test()
        {
            Console.WriteLine("Parent Method Called");
        }
    }

    internal class class3:overriding
    {
        public override void Test()
        {
            Console.WriteLine("Children Method Called");
        }

        public static void Main()
        {
            new class3().Test();
            new overriding().Test();
        }
    }


}
