namespace AccessModifiers_1
{
    // case1 : consuming member of a class from same class of same project
    public class class1
    {
        private void Test1() {

            Console.WriteLine("Private Method");
        }
        internal void Test2()
        {

            Console.WriteLine("Internal Method");
        }
        protected void Test3()
        {

            Console.WriteLine("Protected Method");
        }
        protected internal void Test4()
        {

            Console.WriteLine("Protected Internal Method");
        }
        public void Test5()
        {

            Console.WriteLine("Public Method");
        }

     void Test6()
        {
            Console.WriteLine("Without use access modifier Method");
        }


        static void Main(string[] args)
        {
            class1   class1 = new class1();

            class1.Test1();
            class1.Test2();
            class1.Test3(); 
            class1.Test4();
            class1.Test5();
            class1.Test6();

        }
    }
}