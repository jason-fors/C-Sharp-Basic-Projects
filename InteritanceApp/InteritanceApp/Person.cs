using System;
using System.Collections.Generic;
using System.Text;

namespace InteritanceApp
{
    // Abstract class. Cannot be instantiated.
    public abstract class Person
    {
        // Properties of Person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method for displaying name of a person.
        public abstract void SayName();
        
    }
}
