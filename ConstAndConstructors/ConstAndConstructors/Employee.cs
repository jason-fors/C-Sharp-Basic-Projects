using System;
using System.Collections.Generic;
using System.Text;

namespace ConstAndConstructors
{
    public class Employee
    {
        public Employee(): this(1, "Staff")
        {

        }
        
        public Employee(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public string Title { get; set; }
        public int Id { get; set; }


    }
}
