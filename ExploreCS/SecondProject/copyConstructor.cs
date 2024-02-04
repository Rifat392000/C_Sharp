using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class copyConstructor
    {
        int x;
        public copyConstructor( int value) {
        
            x = value;
        }
        public copyConstructor(copyConstructor obj) {
        
            x = obj.x;
        
        }
        public void printValue()
        {
            Console.WriteLine(x);
        }

        public static void Main(string[] args) {
         
            copyConstructor obj1= new copyConstructor(15);
            copyConstructor obj2 = new copyConstructor(obj1);  

            obj2.printValue();
            obj1.printValue();
            Console.ReadLine();
        
        }
    }
}
