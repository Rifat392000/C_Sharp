using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{

  internal  class Student : IComparable<Student>
    {
        private int id;

        // If you want to explicitly mark the name variable as a non-nullable reference type, meaning it cannot be null by default, you would use the ? symbol:

        private string? name;
        private string? address;
        private int marks;

        // Getters and Setters
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        static void Main(string[] args)
        {
            // Creating six instances of the Student class
            Student student1 = new Student();
            student1.ID = 123;
            student1.Name = "John Doe";
            student1.Address = "123 Main St, Anytown USA";
            student1.Marks = 85;

            Student student2 = new Student();
            student2.ID = 2;
            student2.Name = "Jane Smith";
            student2.Address = "456 Oak Rd, Someville USA";
            student2.Marks = 92;

            Student student3 = new Student();
            student3.ID = 32;
            student3.Name = "Bob Johnson";
            student3.Address = "789 Elm St, Otherville USA";
            student3.Marks = 77;

            Student student4 = new Student();
            student4.ID = 14;
            student4.Name = "Alice Williams";
            student4.Address = "321 Pine Ave, Newtown USA";
            student4.Marks = 88;

            Student student5 = new Student();
            student5.ID = 5;
            student5.Name = "Tom Davis";
            student5.Address = "654 Maple Ln, Oldville USA";
            student5.Marks = 79;

            Student student6 = new Student();
            student6.ID = 6;
            student6.Name = "Sarah Wilson";
            student6.Address = "987 Cedar Rd, Cityville USA";
            student6.Marks = 91;

            List<Student> st = new List<Student>() { student1, student2, student3, student4, student5, student6 };
            st.Sort();
            foreach (Student s in st)
            {
                Console.WriteLine("Student ID: " + s.ID);
                Console.WriteLine("Student Name: " + s.Name);
                Console.WriteLine("Student Address: " + s.Address);
                Console.WriteLine("Student Marks: " + s.Marks);
                Console.WriteLine();
            }

            Console.WriteLine("\n--------------------------------------------------\n");

            st.Reverse(2, 4);
            foreach (Student s in st)
            {
                Console.WriteLine("Student ID: " + s.ID);
                Console.WriteLine("Student Name: " + s.Name);
                Console.WriteLine("Student Address: " + s.Address);
                Console.WriteLine("Student Marks: " + s.Marks);
                Console.WriteLine();
            }

            StudentDataSort sds = new StudentDataSort();

            Console.WriteLine("\n--------------------------------------------------\n");

            st.Sort(sds);

            foreach (Student s in st)
            {
                Console.WriteLine("Student ID: " + s.ID);
                Console.WriteLine("Student Name: " + s.Name);
                Console.WriteLine("Student Address: " + s.Address);
                Console.WriteLine("Student Marks: " + s.Marks);
                Console.WriteLine();
            }


        }

        public int CompareTo(Student? other)
        {
            if(this.ID > other.ID) return 1;
            else if(this.ID < other.ID) return -1;
            else return 0;
        }
    }

   
    }

