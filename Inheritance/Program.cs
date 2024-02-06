namespace Inheritance
{
    internal class Program
    {
       public void Test1()
        {
            Console.WriteLine("Hello Everyone Test 1");
        }

        public void Test2()
        {
            Console.WriteLine("Hello Everyone Test 2");
        }

        public Program()
        {
            Console.WriteLine("Implicit parent constuctor call");
        }

        public Program(int id, string name)
        {
            Console.WriteLine(id+"  "+name);
        }

    }
}