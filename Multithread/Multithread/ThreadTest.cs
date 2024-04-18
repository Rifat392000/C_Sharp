using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithread
{
    
    internal class ThreadTest
    {
        static void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Test1 : {i}");
            }

            Console.WriteLine("Thread 1 Exiting");
        }

        static void Test2()
        {
            for (int i = 1; i <= 80; i++)
            {
                if (i == 55)
                {
                    Console.WriteLine("Thread 2 Going to sleep");
                    Thread.Sleep(10000);
                    Console.WriteLine("Thread 2 Woke up");
                }
                Console.WriteLine($"Test2 : {i}");
            }
            Console.WriteLine("Thread 2 Exiting");
        }

        static void Test3()
        {
            for (int i = 1; i <= 130; i++)
            {
                Console.WriteLine($"Test3 : {i}");
            }
            Console.WriteLine("Thread 3 Exiting");
        }

        static void Test4()
        {
            Console.WriteLine("Ultimate Test");
        }

        void Test5(Object val)
        {
            int value = Convert.ToInt32(val);

            for(int i =0; i< value; i++)
            {
                Console.WriteLine(i);
            }

        }

        static void Main()
        {

            ThreadStart obj1 = new ThreadStart(Test1);
            Thread t1 = new Thread(obj1);

            //or

            ThreadStart obj2 = Test2;
            obj2 += Test4;
            Thread t2 = new Thread(obj2);

            //or

            Thread t3 = new Thread(Test3);

            //or

            ThreadStart obj3 = delegate ()
            {
                Console.WriteLine("Whatsapp  Nigga");
            };
            Thread t4 = new Thread(obj3);

            //or
            ThreadStart obj4 = delegate () { Test4(); };
            Thread t5 = new Thread(obj4);

            //or

            ThreadStart obj5 = () => { Console.WriteLine("Hello World"); };
            Thread t6 = new Thread(obj5);

            //or
            ThreadStart obj6 = () => Test4();
            Thread t7 = new Thread(obj6);


            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();

            ThreadTest tt = new ThreadTest();
            ParameterizedThreadStart pt = tt.Test5;
            Thread t = new Thread(pt);
            t.Start(20);

            Console.WriteLine("Main Thread Exiting");
            Console.WriteLine("____________Hello There.. There Is No Time to Die___________");
        }
    }
}
