namespace Multicast
{

    internal class Program
    {
        public delegate void Numbers(int a, int b);

        //static methods
      static  void Area(int a, int b)
        {
            Console.WriteLine(a*b);
        }
       static void Perimeter(int a, int b)
        {
            Console.WriteLine(2*(a+b)); 
        }
        static void Main(string[] args)
        {
            //In a static methods do not need to create a object instances

            Numbers area = new Numbers(Area);

            area(4, 8);

            Numbers peri = new Numbers(Perimeter);

            peri.Invoke(87, 9);


            Numbers cmn = Area;

            //binding
            cmn += Perimeter;

            //common value

            cmn(5, 7);





        }
    }
}