using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiThread
{
    internal class ThreadLocking
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("[ C sharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented Language ]");
            }
        }

        static void Main()
        {
            ThreadLocking tl = new ThreadLocking();

            Thread t1 = new Thread(tl.Display);
            Thread t2 = new Thread(tl.Display);
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }

    }
}
