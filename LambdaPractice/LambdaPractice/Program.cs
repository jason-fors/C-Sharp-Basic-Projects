using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of employees and populating it.
            List<Employee> employees = new List<Employee>();
            
            Employee employee1 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Smith";
            employee1.Id = 1;

            Employee employee2 = new Employee();
            employee2.FirstName = "Joe";
            employee2.LastName = "King";
            employee2.Id = 2;

            Employee employee3 = new Employee();
            employee3.FirstName = "John";
            employee3.LastName = "Smith";
            employee3.Id = 3;

            Employee employee4 = new Employee();
            employee4.FirstName = "Susie";
            employee4.LastName = "Sarzo";
            employee4.Id = 4;

            Employee employee5 = new Employee();
            employee5.FirstName = "Steve";
            employee5.LastName = "Wilson";
            employee5.Id = 5;

            Employee employee6 = new Employee();
            employee6.FirstName = "Jack";
            employee6.LastName = "Smith";
            employee6.Id = 6;

            Employee employee7 = new Employee();
            employee7.FirstName = "Joe";
            employee7.LastName = "King";
            employee7.Id = 7;

            Employee employee8 = new Employee();
            employee8.FirstName = "John";
            employee8.LastName = "Grant";
            employee8.Id = 8;

            Employee employee9 = new Employee();
            employee9.FirstName = "Larry"; 
            employee9.LastName = "Sarzo";
            employee9.Id = 9;

            Employee employee10 = new Employee();
            employee10.FirstName = "Ward";
            employee10.LastName = "Wilson";
            employee10.Id = 10;

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);


            // Creating list of employees with the first name Joe. 
            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                }
            }

            // Creating list of employees with the first name Joe with a lambda expression
            List<Employee> joeList = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in joeList)
            {
                Console.WriteLine(employee.FirstName);
            }

            // Creating a list of employees with an Id number > 5
            List<Employee> idList = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.Id);
            }

        }
    }
}
