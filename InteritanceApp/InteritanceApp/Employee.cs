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
    }
}
