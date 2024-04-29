using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleAppMultiThread
{
    internal class ThreadPerformance
    {
        static long count1 = 0 , count2 =0;
        static void Increment1()
        {
            for(long i = 0; i < 10000000000; i++)
            {
                count1 += 1;
            }
        }

        static void Increment2()
        {
            for (long i = 0; i < 10000000000; i++)
            {
                count2 += 1;
            }
        }

        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();


            sw1.Start();
            Increment1();
            Increment2();
            sw1.Stop();

            Thread t1 = new Thread(Increment1);
            Thread t2 = new Thread(Increment2);

            sw1.Start();
            t1.Start();
            t2.Start();
            sw2.Stop();

            t1.Join();
            t2.Join();

            Console.WriteLine($"Single Thread Timelapse {sw1.ElapsedMilliseconds}");
            Console.WriteLine($"Multi Thread Timelapse {sw2.ElapsedMilliseconds}");

        }
    }
}
