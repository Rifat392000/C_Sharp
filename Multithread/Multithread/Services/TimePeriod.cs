using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithread.Services
{
    internal class TimePeriod
    {
        int value;
        public TimePeriod(int value) { this.value = value; }
        public void printTime()
        {
            Console.WriteLine($"Time is {value}");
        }
    }
}
