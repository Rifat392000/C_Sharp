using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class FirstTestclass
    {
        public int x = 150;
    }
    class SecondTestclass
    {
        public int x;

        public SecondTestclass(int x) { 
        
            this.x = x;
        }
    }
    internal class multiClass
    {
        public static void Main(string[] args)
        {
            FirstTestclass t1 = new FirstTestclass();
            FirstTestclass t2 = new FirstTestclass();

            Console.WriteLine(t1.x);
            Console.WriteLine(t2.x);

            SecondTestclass t3 = new SecondTestclass(15);
            SecondTestclass t4 = new SecondTestclass(122);
            SecondTestclass t5 = new SecondTestclass(54689);

            Console.WriteLine(t3.x);
            Console.WriteLine(t4.x);
            Console.WriteLine(t5.x);
        }
        
    }

}
