using System;
using System.Collections.Generic;
using System.Text;

namespace InteritanceApp
{
    public class Person
    {
        // Properties of Person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method for displaying name of a person.
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
