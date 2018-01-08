using System;
using System.Collections.Generic;

namespace classes
{
    // Create a class that contains information about employees of a company and define methods to get/set employee name, job title, and start date.
    // Consider the concept of aggregation, and modify the Company class so that you assign employees to a company.
    class Program
    {
        public class Employee
        {
            // private string name;
            // private DateTime startDate;
            // private string jobTitle;

            // create a getter/setter for public access to employee details
            public string Name { get; set; }
            public DateTime StartDate { get; set; }
            public string JobTitle { get; set; }

            // build constructor to create a new employee listing
            public Employee(string Name, DateTime StartDate, string JobTitle)
            {
                this.Name = Name;
                this.StartDate = StartDate;
                this.JobTitle = JobTitle;
            }

        }


        public class Company
        {
            /*
                Some readonly properties
            */
            // private string name;
            // private DateTime createdOn;


            public string Name { get; }
            public DateTime CreatedOn { get; }

            // Create a property for holding a list of current employees
            public List<Employee> employees { get; set; }

            // Create a method that allows external code to add an employee
            public void AddEmployee(Employee newEmployee)
            {
                employees.Add(newEmployee);
            }

            // Create a method that allows external code to remove an employee
            public void RemoveEmployee(Employee employeeLeaving)
            {
                employees.Remove(employeeLeaving);
            }
            public void ListEmployees() 
            {
                foreach (Employee Employee in employees) {
                    Console.WriteLine($"{Employee.Name}");
                }
            }

            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */
            public Company(string Name, DateTime CreatedOn)
            {
                this.Name = Name;
                this.CreatedOn = CreatedOn;
                this.employees = new List<Employee>();
            }
            // Update the Company class to write the name of each employee to the console. Consider a method named ListEmployees().

        }

        static void Main(string[] args)
        {
            // In the Main method, create a company, and three employees, and then assign the employees to the company.
            
            Company GML = new Company ("GML", new DateTime());
            
            Employee Greg = new Employee("Greg", new DateTime(), "President");
            Employee Krys = new Employee("Krys", new DateTime(), "Vice-President");
            Employee Paul = new Employee("Paul", new DateTime(), "Junior Vice-President");
            
            GML.AddEmployee(Greg);
            GML.AddEmployee(Krys);
            GML.AddEmployee(Paul);


            GML.ListEmployees();
            



        }
    }
}
