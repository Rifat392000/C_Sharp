using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Customer
    {
        public int  identity { get; set; }
        public int Custid { get; set; }
        public string Name { get; set; }

        public double Balance { get; set; }

        public string Address { get; set; }


    }

    public class TestCustomer
    {
 public static void Main()
        {
            List<Customer> cus = new List<Customer>();

            Customer c1 = new Customer { Custid = 104, Name = "Rifat", Address = "2/3 NY", Balance = 245.23, identity = 1 };

            // Customer 2
            Customer c2 = new Customer
            {
                identity = 2,
                Custid = 201,
                Name = "Emily",
                Address = "123 Main St, Cityville",
                Balance = 1245.67
            };

            // Customer 3
            Customer c3 = new Customer

            {
                identity = 3,
                Custid = 305,
                Name = "David",
                Address = "45 Oak Rd, Townsville",
                Balance = 578.92
            };

            // Customer 4
            Customer c4 = new Customer
            {
                identity=4,
                Custid = 427,
                Name = "Sophia",
                Address = "9 Maple Ln, Villageton",
                Balance = 3021.45
            };

            cus.Add(c1);
            cus.Add(c2);
            cus.Add(c3);
            cus.Add(c4);

            foreach( Customer customer in cus)
            {
                
               Console.WriteLine($"Customer >-----> {customer.identity}\n");
                Console.WriteLine(customer.Custid);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Address);
                Console.WriteLine(customer.Balance+"\n");

             

            }

        }



    }
}
