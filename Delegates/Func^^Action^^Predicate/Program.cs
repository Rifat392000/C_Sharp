namespace GenericDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = (a, b, c) => a + b + c;

            Action<int, float, double> obj2 = (a, b, c) => Console.WriteLine(a + b + c);

            Predicate <string> obj3 = str =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };

          double d =  obj1.Invoke(12, 54.34f, 67978.254);
            Console.WriteLine(d);
            obj2.Invoke(12, 54.34f, 67978.254);

            Console.WriteLine(obj3("Hello Everyone"));


        }
    }
}