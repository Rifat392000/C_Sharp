using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeManagement
{
    // Employee class represents an individual employee's data
    public class Employee
    {
        public int Id { get; set; } // Unique identifier for the employee
        public string? Name { get; set; } // Name of the employee
        public string? Job { get; set; } // Job title or role of the employee
        public double Salary { get; set; } // Salary of the employee
    }

    // EmployeeCollection class holds a collection of Employee objects and implements IEnumerable<Employee>
    // The purpose of this class is to provide a way to manage a collection of employees and iterate over them
    public class EmployeeCollection : IEnumerable<Employee>
    {
        private List<Employee> employees = new List<Employee>(); // List to store Employee objects

        // AddEmployee method adds a new Employee object to the collection
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        // Count property returns the number of employees in the collection
        public int Count => employees.Count;

        // Indexer allows accessing employees by index
        public Employee this[int index] => employees[index];

        // GetEnumerator method returns an EmployeeEnumerator instance to iterate over the employees
        // The IEnumerable<Employee> interface is implemented to allow foreach loops and other enumeration constructs
        public IEnumerator<Employee> GetEnumerator()
        {
            return new EmployeeEnumerator(employees);
        }

        // Required by IEnumerable.GetEnumerator() method
        // This implementation is necessary to support non-generic enumeration scenarios
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    // EmployeeEnumerator class implements IEnumerator<Employee> to iterate over the Employee collection
    // The purpose of this class is to provide a way to enumerate over the employees in the collection
    public class EmployeeEnumerator : IEnumerator<Employee>
    {
        private List<Employee> employees; // Reference to the employee list
        private int currentIndex = -1; // Index of the current employee (-1 means before the first element)

        // Constructor to initialize the EmployeeEnumerator with the employee list
        // 'this' keyword is used to refer to the current instance of the class and disambiguate from the parameter name
        public EmployeeEnumerator(List<Employee> employees)
        {
            this.employees = employees;
        }

        // Current property returns the current Employee object
        public Employee Current => employees[currentIndex];

        // Required by IEnumerator.Current
        // This implementation is necessary to support non-generic enumeration scenarios
        object IEnumerator.Current => Current;

        // MoveNext method moves the enumerator to the next employee in the collection
        public bool MoveNext()
        {
            if (++currentIndex >= employees.Count)
            {
                return false; // We have reached the end of the collection
            }

            return true; // Successfully moved to the next employee
        }

        // Reset method is not implemented in this example (throws NotImplementedException)
        public void Reset()
        {
            throw new NotImplementedException();
        }

        // Dispose method is not necessary for this example (no unmanaged resources)
        public void Dispose() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new EmployeeCollection instance
            EmployeeCollection employeeCollection = new EmployeeCollection();

            // Add employees to the collection
            employeeCollection.AddEmployee(new Employee { Id = 1, Name = "John Doe", Job = "Manager", Salary = 5000.0 });
            employeeCollection.AddEmployee(new Employee { Id = 2, Name = "Jane Smith", Job = "Developer", Salary = 4500.0 });
            employeeCollection.AddEmployee(new Employee { Id = 3, Name = "Bob Johnson", Job = "Designer", Salary = 4200.0 });
            employeeCollection.AddEmployee(new Employee { Id = 4, Name = "Alice Williams", Job = "Analyst", Salary = 3800.0 });
            employeeCollection.AddEmployee(new Employee { Id = 5, Name = "Tom Davis", Job = "Tester", Salary = 3500.0 });
            employeeCollection.AddEmployee(new Employee { Id = 6, Name = "Sarah Wilson", Job = "Administrator", Salary = 4000.0 });
            employeeCollection.AddEmployee(new Employee { Id = 7, Name = "Mike Brown", Job = "Intern", Salary = 2000.0 });

            // Iterate over the employees using foreach loop
            // The foreach loop works because EmployeeCollection implements IEnumerable<Employee>
            foreach (Employee emp in employeeCollection)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Job: {emp.Job}, Salary: {emp.Salary}");
            }
        }
    }
}