namespace Enumeration
{

    public enum Days
    {
        Saturday,Sunday,Monday,Tuesday=15,Wednesday,Thursday,Friday
    }
    internal class Program
    {
        static void Main(string[] args)


        {
            Days d = 0;
            Console.WriteLine(d);

            Days d1 = Days.Sunday;
            Console.WriteLine(d1);

            Days d2 = (Days)16;
            Console.WriteLine(d2);
            Console.WriteLine((int)d2);

            

            foreach(int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i);
            }

            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
        }
    }
}