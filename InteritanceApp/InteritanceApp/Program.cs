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

            // Call method from Employee to display name
            employee.SayName();
            employee.Quit();

            
            // Creating object of type IQuittable.
            IQuittable quittable = new Employee();
            quittable.Quit();

        }
    }
}
