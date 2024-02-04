using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class staticVSconst
    {
        static int p;
        const float pi = 3.14f;
        int v1, v2;
        readonly int v3;
        public staticVSconst(int val)
        {
            p = val;
          
            
        }
        public staticVSconst(int v1,int v2,int v3)
        {
            
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
        public void printvalue()
        {
            Console.WriteLine("Static value is "+p + " " +"Constant value is "+ pi);
        }

        public void printval()
        {
            Console.WriteLine( v1 + " " + v2 + " " + v3);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(p);
            staticVSconst s1=   new staticVSconst(52);
            staticVSconst s2 = new staticVSconst(2);
            s2.printvalue(); // Static value is 2 Constant value is 3.14
            s1.printvalue(); // Static value is 2 Constant value is 3.14
            Console.WriteLine(p);

            staticVSconst s3 = new staticVSconst(11,33,54);
            staticVSconst s4 = new staticVSconst(45,85,68);
            s4.printval();
            s3.printval();

            s3.v1 = 5454;
            s3.v2 = 8888;
            //s3.v3 = 454; not possible after initialize readonly variable value change
            s4.v2 = 1;
            s4.v1 = 141;
            //s4.v3 = 44; not possible after initialize readonly variable value change
            s4.printval();
            s3.printval();
        }

    }
}
