using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class parameterConstructor
    {
        int x;
        public parameterConstructor(int id) { 
          x = id;
        }
        public void printValue()
        {
            Console.WriteLine("value : "+x);
        }

        public static void  Main(string[] args)
        {
            parameterConstructor f1 = new parameterConstructor(3);
            parameterConstructor f2 = new parameterConstructor(8);
            
            f2.printValue();    
            f1.printValue();
        }
    }
}
