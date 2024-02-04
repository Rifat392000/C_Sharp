namespace AccessModifiers_2
{
    // case 4 : consuming members of a class from child class of different project
    internal class class5 : AccessModifiers_1.class1
    {
        static void Main(string[] args)
        {
            class5 class5 = new class5();
            class5.Test3();
            class5.Test4();
            class5.Test5();
        }
    }
}