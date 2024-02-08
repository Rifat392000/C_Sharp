namespace AbstractClass
{
    abstract class Program
    {
    
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public abstract void mul(int a, int b);
        public abstract void div(int a, int b);
    }

    class AbsChild : Program
    {
        public override void mul(int a, int b)
        {
           Console.WriteLine(a*b);
        }
        public override void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public static void Main(string[] args)
        {
            AbsChild a = new AbsChild();
            a.mul(1, 2);
            a.div(8, 2);
            a.add(1, 2);
            a.sub(1, 2);

            Program p = a;
            p.mul(5, 2);
            p.div(8, 2);
            p.add(1, 21);
            p.sub(2, 2);
        }
    }

}