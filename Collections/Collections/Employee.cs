using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Job { get; set; }
        public double Salary { get; set; }
    }

    public class Organization : IEnumerable
    {

        List<Employee> Emps = new List<Employee>();
        public void Add(Employee Emp)
        {
          Emps.Add(Emp);
        }

        public int Count { get { return Emps.Count;} }
         
        public Employee this[int index] { get {  return Emps[index]; } }
        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnm(this); // here this represnts current class means Organization
        }
    }

    public class OrganizationEnm : IEnumerator
    {
        Organization? OrgColl;
        int CurrentIndex;
        Employee? CurrentEmloyee;

        public OrganizationEnm(Organization org)
        {
            OrgColl = org;
            CurrentIndex = -1; // by default Before First so that is -1
        }

        public object Current {

            get
            {
                return CurrentEmloyee;
            }


            }

        public bool MoveNext()
        {
           if(++CurrentIndex >= OrgColl.Count)
            {
                return false;
            }
           else
            {
                CurrentEmloyee = OrgColl[CurrentIndex];
               
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    class TestEmployee
    {
        public static void Main(string[] args)
        {
      Organization list = new Organization();
            
            // Adding instances of the Employee class using object initializers
            list.Add(new Employee { Id = 1, Name = "John Doe", Job = "Manager", Salary = 5000.0 });
            list.Add(new Employee { Id = 2, Name = "Jane Smith", Job = "Developer", Salary = 4500.0 });
            list.Add(new Employee { Id = 3, Name = "Bob Johnson", Job = "Designer", Salary = 4200.0 });
            list.Add(new Employee { Id = 4, Name = "Alice Williams", Job = "Analyst", Salary = 3800.0 });
            list.Add(new Employee { Id = 5, Name = "Tom Davis", Job = "Tester", Salary = 3500.0 });
            list.Add(new Employee { Id = 6, Name = "Sarah Wilson", Job = "Administrator", Salary = 4000.0 });
            list.Add(new Employee { Id = 7, Name = "Mike Brown", Job = "Intern", Salary = 2000.0 });

            // You can now access and manipulate the employees in the list
            foreach (Employee emp in list)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Job: {emp.Job}, Salary: {emp.Salary}");
            }
        }
    }
}