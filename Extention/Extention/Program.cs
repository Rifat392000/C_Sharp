using System;

namespace Extension
{
    internal class Program
    {
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }

        public Action Test2 = () => Console.WriteLine("Method 2");
    }
}
