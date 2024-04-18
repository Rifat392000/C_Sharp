using Multithread.Services;
using Multithread.Utils;
using Multithread.Utils.Print;

namespace Multithread
{
    internal class Program : Interface
    {

        public double Divide(int a, int b)
        {
            return (double)a / b;
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void printMe(int a, int b)
        {
            Console.WriteLine($"{a} and {b}");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.printMe(0, 0);
            program.Multiply(7, 3);
           double d = program.Divide(7, 3);

            Print p = new Print();
            p.printFunc(d);
            
            TimePeriod t = new TimePeriod(5);
            t.printTime();

        }

      
    }
}