using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionDelegates
{
    internal delegate void AddNum(int x, int y);
    internal delegate string Name(string name);
    internal class Test
    {
        internal void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        internal static string NameofPerson(string name)
        {
            return name;
        }



    }
}
