using System;
using System.Threading;

namespace ConsoleAppMultiThread
{
    internal class ThreadPriorities
    {
        static long count1 = 0, count2 = 0;
        static CancellationTokenSource cts = new CancellationTokenSource();

        static void Counter1()
        {
            while (true)
            {
                if (cts.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Counter1 is exiting.");
                    break;
                }
                count1++;
            }
        }

        static void Counter2()
        {
            while (true)
            {
                if (cts.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Counter2 is exiting.");
                    break;
                }
                count2++;
            }
        }

        static void Main()
        {
            Thread t1 = new Thread(Counter1);
            Thread t2 = new Thread(Counter2);
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();

            Console.WriteLine("Main thread going to sleep");
            Thread.Sleep(5000);
            Console.WriteLine("Main thread woke up");

            cts.Cancel(); // Request cancellation

            t1.Join();
            t2.Join();

            Console.WriteLine("Count 1 " + count1);
            Console.WriteLine("Count 2 " + count2);
            Console.WriteLine("Main Thread Exit");
        }
    }
}