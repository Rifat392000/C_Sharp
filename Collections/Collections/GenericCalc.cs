using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericCalc <T>
    {
     internal void Add(T a , T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+d2);
        }

      internal void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
      internal void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
      internal void Divide(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }

     
    }

    class Play
    {
        static void Main()
        {

            GenericCalc<int> calc = new GenericCalc<int>();

            calc.Add(54, 8);
            calc.Mul(54, 4);

            GenericCalc<float> dub = new GenericCalc<float>();

            dub.Add(24.52f, 578.32f);
            dub.Divide(24.34f, 4.5f);

        }
    }
}
