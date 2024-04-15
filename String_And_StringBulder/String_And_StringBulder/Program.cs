using System;
using System.Text;
using System.Diagnostics;

namespace String_And_StringBulder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            string s = "";

            sw1.Start();
            for (int i = 1; i <= 100000; i++)
            {
                s += i.ToString();
            }
            sw1.Stop();

            StringBuilder sb = new StringBuilder();
            sw2.Start();
            for (int i = 1; i <= 100000; i++)
            {
                sb.Append(i);
            }
           
            sw2.Stop();

            Console.WriteLine("String concatenation time: " + sw1.ElapsedMilliseconds + " ms");
            Console.WriteLine("StringBuilder time: " + sw2.ElapsedMilliseconds + " ms");

            Console.ReadLine(); // To keep the console window open
        }
    }
}