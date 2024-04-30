namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Array.Resize(ref arr, 15);
            Console.WriteLine("Hello, World!");
        }
    }
}