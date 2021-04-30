using System;

namespace InteritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate employee class
            Employee employee = new Employee();

            // Assign values to object
            employee.FirstName = "Sample";       
            employee.LastName = "Student";
            employee.Id = 1;


            // Call method from Employee to display name
            employee.SayName();
            employee.Quit();

            
            // Creating object of type IQuittable.
            IQuittable quittable = new Employee();
            quittable.Quit();


            // Checking if two employees are the same.
            Employee employee2 = new Employee();
            employee2.FirstName = "Sample";
            employee2.LastName = "Student";
            employee2.Id = 1;

            Employee employee3 = new Employee();
            employee3.FirstName = "Sample";
            employee3.LastName = "Student2";
            employee3.Id = 3;


            Console.WriteLine(employee == employee2);
            Console.WriteLine(employee == employee3);
            Console.WriteLine("Should be true then false.");
        }
    }
}
