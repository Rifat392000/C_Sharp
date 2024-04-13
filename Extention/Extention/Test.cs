using Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Test3();
            program.Test3(4);
            program.Test1();
            program.Test2();

            int i = 5;
          long value =  i.Factorial();

            Console.WriteLine(value);

            string str = "heLLO hoW ArE yOu";

            Console.WriteLine(str.ToProper());


        }
    }
}
