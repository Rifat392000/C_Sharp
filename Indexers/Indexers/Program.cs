namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1001, 2447.24, "Rifat", "Engineer", "System Designer", "Osaka");

            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            Console.WriteLine(emp[3]);
            Console.WriteLine(emp[4]);
            Console.WriteLine(emp[5]);
            Console.WriteLine(emp[6]);

            Console.WriteLine();
            emp[1] = 200;
            emp[2] = 500000.23;
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);

            emp[3] = "Alis";

            Console.WriteLine(emp[3]);

            Console.WriteLine(emp[4]);
            Console.WriteLine(emp[5]);

            emp[6] = "Rocket Engineer";
            Console.WriteLine(emp[6]);
        }
    }
}