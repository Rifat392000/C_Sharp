using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_1
{
    // case 3: consuming member of a class from non child class of same project
    internal class class4
    {
        public static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.Test2();
            c1.Test4();
            c1.Test5();
        }
    }
}
