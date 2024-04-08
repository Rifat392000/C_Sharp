using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast
{
    public delegate string toast(string text);
    internal class AnonymousMethods
    {
        public static void Main()
        {
            toast t = delegate (string text)
            {
                return "Hello " + text;
            };

            Console.WriteLine(t.Invoke("Rifat"));
        } 

    }
}
