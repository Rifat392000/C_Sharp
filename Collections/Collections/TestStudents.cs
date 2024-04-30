using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{

  internal  class TestStudent
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int Marks { get; set; }

        public static int CompareTestStudent(TestStudent s1, TestStudent s2)
        {
            return s1.Name.CompareTo(s2?.Name);

        }
    }
    
    class Program1
    {
        static void Main(string[] args)
        {
            // Creating six instances of the TestStudent class
            TestStudent TestStudent1 = new TestStudent
            {
                ID = 1,
                Name = "John Doe",
                Address = "123 Main St, Anytown USA",
                Marks = 85
            };

            TestStudent TestStudent2 = new TestStudent
            {
                ID = 2,
                Name = "Jane Smith",
                Address = "456 Oak Rd, Someville USA",
                Marks = 92
            };

            TestStudent TestStudent3 = new TestStudent
            {
                ID = 3,
                Name = "Bob Johnson",
                Address = "789 Elm St, Otherville USA",
                Marks = 77
            };

            TestStudent TestStudent4 = new TestStudent
            {
                ID = 4,
                Name = "Alice Williams",
                Address = "321 Pine Ave, Newtown USA",
                Marks = 88
            };

            TestStudent TestStudent5 = new TestStudent
            {
                ID = 5,
                Name = "Tom Davis",
                Address = "654 Maple Ln, Oldville USA",
                Marks = 79
            };

            TestStudent TestStudent6 = new TestStudent
            {
                ID = 6,
                Name = "Sarah Wilson",
                Address = "987 Cedar Rd, Cityville USA",
                Marks = 91
            };

            List<TestStudent> li = new List<TestStudent>() { TestStudent1, TestStudent2, TestStudent3, TestStudent4,TestStudent6,TestStudent5};



            /*Comparison<TestStudent> ts = new Comparison<TestStudent>(TestStudent.CompareTestStudent);

            li.Sort(ts);*/


            li.Sort(TestStudent.CompareTestStudent);


            /*    li.Sort(delegate (TestStudent s1, TestStudent s2)
                {
                    return s1.Name.CompareTo(s2?.Name);

                });*/




            //   li.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));





            foreach (TestStudent s in li)
            {
                Console.WriteLine("Student ID: " + s.ID);
                Console.WriteLine("Student Name: " + s.Name);
                Console.WriteLine("Student Address: " + s.Address);
                Console.WriteLine("Student Marks: " + s.Marks);
                Console.WriteLine();
            }


        }
    }
}
