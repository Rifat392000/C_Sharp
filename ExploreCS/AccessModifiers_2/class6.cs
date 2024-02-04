using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_2
{
    // case 3: consuming member of a class from non child class of different project
    internal class class6
    {
        public static void Main(string[] args)
        {
            AccessModifiers_1.class1 class1 = new AccessModifiers_1.class1();
            class1.Test5();
        }
    }
}
