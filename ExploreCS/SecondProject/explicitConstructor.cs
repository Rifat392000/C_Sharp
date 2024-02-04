using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class explicitConstructor
    {
        // parameter less explicit constructor
        public explicitConstructor() {
            Console.WriteLine("hello Welcome to explicit constructor");
        }
        // parameter base explicit constructor
        public explicitConstructor(int id,string name) {
            Console.WriteLine(id+" "+name);
        }

        public static void Main(string[] args)
        {
            new explicitConstructor();
            new explicitConstructor(24,"Rifat");

            explicitConstructor ex = new explicitConstructor();
            explicitConstructor explicitConstructor = new explicitConstructor();
            explicitConstructor p = new explicitConstructor(28,"Bob");
            


        }
    }
}
