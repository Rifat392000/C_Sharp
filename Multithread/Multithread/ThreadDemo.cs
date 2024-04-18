using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithread
{
    internal class ThreadDemo
    {
        public static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";

            Console.WriteLine(Thread.CurrentThread.Name);

        }
    }
}
