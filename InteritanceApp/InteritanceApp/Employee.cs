using System;
using System.Collections.Generic;
using System.Text;

namespace InteritanceApp
{
    public class Employee: Person, IQuittable       // Inheriting Person class
    {
        public int Id { get; set; }     // Property of Employee class

        // Implementing abstract method from Person class.
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit.");
        }
        

        // Defining == operator for employees.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool sameEmployee = (employee1.Id == employee2.Id);
            return sameEmployee;
        }

        // Must define != when we define == operator.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool sameEmployee = (employee1.Id != employee2.Id);
            return sameEmployee;
        }
    }
}
