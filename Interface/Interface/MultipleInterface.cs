using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface I1
    {
        void value(int value);
        void show();
    }
    interface I2 { void show();
    
        string userName(int value);
    }
    internal class MultipleInterface: I1, I2
    {
        public void show() {

            Console.WriteLine("Hello I am there");
        }

        void I1.value(int value) { Console.WriteLine(value); }

        string I2.userName(int value) { 
            
            if(value > 0)
            {
                return "Hello";
            }
            else
            {
                return "World";
            }
        
        }

        public static void Main(string[] args)
        {
            MultipleInterface a = new MultipleInterface();

            a.show();

            I1 i1 = a;

            I2 i2 = a;

            i1.value(20);
           string v= i2.userName(321);
            Console.WriteLine(v);
        }

    }
}
