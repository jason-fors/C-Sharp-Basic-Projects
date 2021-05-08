using System;
using System.Collections.Generic;

namespace InteritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate employee class with generic as a string
            Employee<string> employee = new Employee<string>();

            // This is still wrong... ------------------
            employee.Things.Add("President");
            employee.Things.Add("CEO");

            Console.WriteLine("First Employee title: " + employee.Things[0]);

            // Assign values to object
            employee.FirstName = "Sample";       
            employee.LastName = "Student";
            employee.Id = 1;


            // Instantiate employee class with generic as integer
            Employee<int> employee4 = new Employee<int>();
            employee4.Things.Add(4);
            employee4.Things.Add(22);
            Console.WriteLine("Latest Employee number: " + employee4.Things[0]);


            // Call method from Employee to display name
            employee.SayName();
            employee.Quit();

            Console.ReadLine();
            
            //// Creating object of type IQuittable.
            //IQuittable quittable = new Employee();
            //quittable.Quit();


            //// Checking if two employees are the same.
            //Employee employee2 = new Employee();
            //employee2.FirstName = "Sample";
            //employee2.LastName = "Student";
            //employee2.Id = 1;

            //Employee employee3 = new Employee();
            //employee3.FirstName = "Sample";
            //employee3.LastName = "Student2";
            //employee3.Id = 3;


            //Console.WriteLine(employee == employee2);
            //Console.WriteLine(employee == employee3);
            //Console.WriteLine("Should be true then false.");
        }
    }
}
