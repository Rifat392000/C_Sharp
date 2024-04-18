using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiThread
{
    internal class ThreadMainExitLast
    {
        public static void testMethod1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("testMethod1: " + i);
            }
            Thread.Sleep(5000);
            Console.WriteLine("Thread 1 Exiting");

        }

        public static void testMethod2()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 55)
                {
                    Console.WriteLine("Thread 2 Going to sleep");
                    Thread.Sleep(10000);
                    Console.WriteLine("Thread 2 Woke up");
                }
                Console.WriteLine("testMethod2: " + i);
            }
            Console.WriteLine("Thread 2 Exiting");
        }

        public static void testMethod3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("testMethod3: " + i);
            }
            Console.WriteLine("Thread 3 Exiting");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Start");

            Thread t1 = new Thread(testMethod1);
            Thread t2 = new Thread(testMethod2);
            Thread t3 = new Thread(testMethod3);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join(3000);
            t2.Join();
            t3.Join();

            Console.WriteLine("Thread Main Exiting Last _________//////**************");
        }

    }



}
