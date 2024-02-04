using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject
{
    internal class First
    {
        int x=20, y=30;
        public First() {
            Console.WriteLine("Hello I am First class");
        }

        public static void Main()
        {
            First first;
            first = new First();

            First second = first;

            Console.WriteLine(first.x + " " + first.y);
            Console.WriteLine(second.x + " " + second.y);

            first.x= 75;

            Console.WriteLine(first.x + " " + first.y);
            Console.WriteLine(second.x + " " + second.y);

            second.x = 879;
            second.y = 57;
            Console.WriteLine(first.x + " " + first.y);
            Console.WriteLine(second.x + " " + second.y);
        }
    }
}
