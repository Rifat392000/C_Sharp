using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class Static_nonStatic
    {
        int x=5, y=18;

        
        public Static_nonStatic()
        {
          
        }
        public Static_nonStatic(int x, int y) {
            this.x = x;
            this.y = y;
            
        }
        public void printMe()
        {
            Console.Write(" "+x + " " + y+" ");
            Console.Write(this.x + " " + this.y);
            Console.WriteLine();
        }
        public static void Main(string[] a)
        {
            
            Console.WriteLine("Main Method <(:-)");
            Static_nonStatic d1 = new Static_nonStatic(17, 25);
            new Static_nonStatic().printMe();
            new Static_nonStatic(105, 224).printMe();
            Console.WriteLine("Main Method :)");
            d1.printMe();
            Console.ReadLine();
        }
        static Static_nonStatic()
        {
            Console.WriteLine("Static Method");
        }

    }
}
