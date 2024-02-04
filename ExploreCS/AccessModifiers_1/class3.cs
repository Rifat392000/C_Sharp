using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_1
{
    //case 2: consuming members of a class from child class of same project
    internal class class3:class1
    {
        public static void Main()
        {
          
            class3 c1 = new class3();
            c1.Test2();
            c1.Test3();
            c1.Test4();
            c1.Test5();


        }
        
    }
}
