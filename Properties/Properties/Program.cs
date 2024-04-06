
namespace Properties
{

    internal class child : Customer
    {
        
        internal child(int Cid, bool Status, string Name, double Balance, Cities City, string State) : base(Cid, Status, Name, Balance, City, State)
        {
            
        }
       
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            child c = new child(101,false,"Rifat",45600.487,Cities.DHK,"Arizona");

            Console.WriteLine(c.State);


            Console.WriteLine(c.Cid);

            if(c.Status == false)
            {
                Console.WriteLine("In Active");
            }

            else
            {
                Console.WriteLine("Active");
            }

            c.Status = true;

            Console.WriteLine(c.Name);

            Console.WriteLine(c.balance);
            c.balance = 5000;
            Console.WriteLine(c.balance);

            Console.WriteLine(c.City);
            c.City = Cities.LDN;

            Console.WriteLine(c.City);

            Console.WriteLine(c.Country);       
        }
    }
}