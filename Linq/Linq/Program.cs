using System.Linq;
namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 24, 68, 12, 75, 25, 41, 35, 97, 21, 34, 44, 5654, 78, 2, 8, 6544, 78, 12, 54, 36, 7, 8, 89, 54, 21, 35, 653, 45 };

            var q1 = from i in arr select i;

            var q2 = from i in arr where i<23  select i;

            var q3 = from i in arr where i>40 orderby i descending select i;

            foreach( var i in q1 ) { Console.WriteLine(i); }
            foreach( var i in q2 ) {  Console.WriteLine(i); }
            foreach( var i in q3 ) {  Console.WriteLine(i); }

        }

    }
}